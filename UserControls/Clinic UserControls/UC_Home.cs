using ClinicManagementSystem.Data;
using ClinicManagementSystem.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
// These are essential for the HopeButton and UI components
using ReaLTaiizor.Controls;
using ReaLTaiizor.Util;

namespace ClinicManagementSystem
{
    public partial class UC_Home : UserControl
    {
        public static UC_Home Instance { get; private set; }
        public const int LowStockThreshold = 3;

        // This keeps the Grid and your JSON list perfectly synced
        private BindingSource recordBindingSource = new BindingSource();

        public UC_Home()
        {
            InitializeComponent();
            Instance = this;

            ClinicData.LoadData();

            // Force alerts to update when the view changes
            this.VisibleChanged += (s, e) => { if (this.Visible) UpdateLowInventoryAlert(); };
            this.Load += (s, e) => UpdateLowInventoryAlert();

            SetupGridProperties();
            RefreshDashboard();
        }

        private void SetupGridProperties()
        {
            dgvStudentRecords.EnableHeadersVisualStyles = false;
            dgvStudentRecords.BackgroundColor = Color.White;
            dgvStudentRecords.RowHeadersVisible = false;
            dgvStudentRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Grid starts locked to prevent accidental typing
            dgvStudentRecords.ReadOnly = true;
            dgvStudentRecords.AllowUserToAddRows = false;
            dgvStudentRecords.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            dgvStudentRecords.DataBindingComplete += DgvStudentRecords_DataBindingComplete;
        }

        public void RefreshDashboard()
        {
            Total_0.Text = ClinicData.StudentRecords.Count.ToString();

            // Link the list to the grid via the BindingSource
            recordBindingSource.DataSource = ClinicData.StudentRecords;
            dgvStudentRecords.DataSource = recordBindingSource;

            recordBindingSource.ResetBindings(false);
            UpdateLowInventoryAlert();
        }

        // --- ADD BUTTON (IN-PLACE) ---
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvStudentRecords.ReadOnly = false;
            btnUpdate.Text = "Editing Mode...";
            btnUpdate.BackColor = Color.Orange;

            var newRec = new StudentRecord
            {
                StudentID = "NEW",
                StudentName = "",
                DateVisited = DateTime.Now
            };
            ClinicData.StudentRecords.Add(newRec);

            recordBindingSource.ResetBindings(false);

            // Focus the new row automatically
            int lastRow = dgvStudentRecords.Rows.Count - 1;
            dgvStudentRecords.CurrentCell = dgvStudentRecords.Rows[lastRow].Cells[0];
            dgvStudentRecords.BeginEdit(true);
        }

        // --- UPDATE BUTTON (TOGGLE EDIT MODE) ---
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudentRecords.ReadOnly)
            {
                dgvStudentRecords.ReadOnly = false;
                btnUpdate.Text = "Editing Mode...";
                btnUpdate.BackColor = Color.Orange;
                MessageBox.Show("Editing Enabled: Click any cell to change details.");
            }
            else
            {
                dgvStudentRecords.ReadOnly = true;
                btnUpdate.Text = "Update";
                btnUpdate.BackColor = Color.DodgerBlue;
            }
        }

        // --- SAVE BUTTON (JSON SYNC) ---
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            dgvStudentRecords.EndEdit(); // Commit current typing
            ClinicData.SaveData();

            dgvStudentRecords.ReadOnly = true;
            btnUpdate.Text = "Update";
            btnUpdate.BackColor = Color.DodgerBlue;

            MessageBox.Show("Changes saved successfully!");
            RefreshDashboard();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudentRecords.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Delete selected record?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var record = (StudentRecord)dgvStudentRecords.SelectedRows[0].DataBoundItem;
                    ClinicData.StudentRecords.Remove(record);
                    ClinicData.SaveData();
                    RefreshDashboard();
                }
            }
        }

        // --- NAVIGATION TO INVENTORY ---
        private void LowInvAlertBtn_Click(object sender, EventArgs e)
        {
            var mainDashboard = this.ParentForm as ClinicStaffDashboard;
            if (mainDashboard != null)
            {
                mainDashboard.ShowInventoryPage();
                if (mainDashboard.inventoryControl != null)
                {
                    mainDashboard.inventoryControl.HighlightLowStock();
                }
            }
        }

        // --- UI STYLING & SEARCH ---
        private void DgvStudentRecords_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Header Style
            dgvStudentRecords.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvStudentRecords.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStudentRecords.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            // Standard Row Style (Ensures info is black on white)
            dgvStudentRecords.DefaultCellStyle.BackColor = Color.White;
            dgvStudentRecords.DefaultCellStyle.ForeColor = Color.Black;
            dgvStudentRecords.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);

            // Selected Row Style (Ensures text stays black when highlighted yellow)
            dgvStudentRecords.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dgvStudentRecords.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvStudentRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            // This forces the grid to repaint so the info "appears"
            dgvStudentRecords.Invalidate();
        }

        private void PerformStudentSearch()
        {
            string term = textBox1.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(term))
            {
                recordBindingSource.DataSource = ClinicData.StudentRecords;
            }
            else
            {
                var filtered = ClinicData.StudentRecords.Where(r =>
                    (r.StudentID?.ToLower().Contains(term) ?? false) ||
                    (r.StudentName?.ToLower().Contains(term) ?? false)).ToList();
                recordBindingSource.DataSource = filtered;
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e) => PerformStudentSearch();
        private void textBox1_TextChanged(object sender, EventArgs e) => PerformStudentSearch();

        public void UpdateLowInventoryAlert()
        {
            int lowCount = InventoryData.InventoryItems.Count(i => (i.Quantity ?? 0) <= LowStockThreshold);

            // This logic updates the HopeButton style based on stock levels
            if (lowCount > 0)
            {
                LowInvAlertBtn.ButtonType = HopeButtonType.Danger;
                LowInvAlertBtn.Text = $"      Low Inventory ({lowCount})";
            }
            else
            {
                LowInvAlertBtn.ButtonType = HopeButtonType.Primary;
                LowInvAlertBtn.Text = "      Low Inventory";
            }
        }
    }
}