using ClinicManagementSystem.Data;
using ClinicManagementSystem.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class UC_Home : UserControl
    {
        public static UC_Home Instance { get; private set; }
        public const int LowStockThreshold = 3;

        public UC_Home()
        {
            InitializeComponent();
            Instance = this;

            // --- THE FIX: FORCE UPDATE ON EVERY POSSIBLE VIEW CHANGE ---
            this.VisibleChanged += (s, e) => { if (this.Visible) UpdateLowInventoryAlert(); };
            this.Load += (s, e) => UpdateLowInventoryAlert();
            this.ParentChanged += (s, e) => UpdateLowInventoryAlert();

            // Initialize Grid
            dgvStudentRecords.EnableHeadersVisualStyles = false;
            dgvStudentRecords.BackgroundColor = Color.White;
            dgvStudentRecords.RowHeadersVisible = false;
            dgvStudentRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentRecords.ReadOnly = true;
            dgvStudentRecords.AllowUserToAddRows = false;
            dgvStudentRecords.DataBindingComplete += DgvStudentRecords_DataBindingComplete;

            RefreshDashboard();
        }

        public void UpdateLowInventoryAlert()
        {


            int lowCount = InventoryData.InventoryItems
                 .Count(i => (i.Quantity ?? 0) <= LowStockThreshold);

            LowInvAlertBtn.ButtonType = lowCount > 0
                ? ReaLTaiizor.Util.HopeButtonType.Danger
                : ReaLTaiizor.Util.HopeButtonType.Primary;

            LowInvAlertBtn.Text = lowCount > 0
                ? $"      Low Inventory ({lowCount})"
                : "      Low Inventory";
        }

        private void DgvStudentRecords_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // 1. HEADER: SteelBlue, White text, NO BOLD (Clean Look)
            dgvStudentRecords.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvStudentRecords.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStudentRecords.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular); // Regular makes it clean

            // 2. FIX THE YELLOW HEADER: Keep headers Blue even when the row is selected
            dgvStudentRecords.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvStudentRecords.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            // 3. ROWS: White background, Yellow highlight when clicked
            dgvStudentRecords.DefaultCellStyle.BackColor = Color.White;
            dgvStudentRecords.DefaultCellStyle.ForeColor = Color.Black;
            dgvStudentRecords.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dgvStudentRecords.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvStudentRecords.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);

            // 4. CLEANUP: No extra gray bars or arrows
            dgvStudentRecords.RowHeadersVisible = false;
            dgvStudentRecords.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvStudentRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudentRecords.BackgroundColor = Color.White;


            // 5. CLEAR SELECTION: Stops the first row from being yellow immediately on load
            dgvStudentRecords.ClearSelection();
        }

        public void RefreshDashboard()
        {
            int todayCount = ClinicData.StudentRecords.Count(r => r.DateVisited.Date == DateTime.Today);
            Total_0.Text = todayCount.ToString();

            dgvStudentRecords.DataSource = null;
            if (ClinicData.StudentRecords != null)
            {
                dgvStudentRecords.DataSource = ClinicData.StudentRecords.ToList();
            }
            UpdateLowInventoryAlert();
        }

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

        // Search and Record logic remains the same
        private void SearchBtn_Click(object sender, EventArgs e) => PerformStudentSearch();
        private void textBox1_TextChanged(object sender, EventArgs e) => PerformStudentSearch();

        private void PerformStudentSearch()
        {
            string term = textBox1.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(term))
                dgvStudentRecords.DataSource = ClinicData.StudentRecords.ToList();
            else
                dgvStudentRecords.DataSource = ClinicData.StudentRecords.Where(r =>
                    (r.StudentID?.ToLower().Contains(term) ?? false) ||
                    (r.StudentName?.ToLower().Contains(term) ?? false)).ToList();
            dgvStudentRecords.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string studentId = Microsoft.VisualBasic.Interaction.InputBox("Enter Student ID:", "New Record", "");
            if (string.IsNullOrWhiteSpace(studentId)) return;

            if (ClinicData.StudentRecords.Any(r => r.StudentID == studentId))
            {
                MessageBox.Show("This Student ID already exists.");
                return;
            }

            string name = Microsoft.VisualBasic.Interaction.InputBox($"ID: {studentId}\nEnter Name:", "New Record", "");
            if (string.IsNullOrWhiteSpace(name)) return;

            string course = Microsoft.VisualBasic.Interaction.InputBox("Enter Course:", "New Record", "");
            string symptoms = Microsoft.VisualBasic.Interaction.InputBox("Enter Symptoms:", "New Record", "");
            string medicine = Microsoft.VisualBasic.Interaction.InputBox("Enter Medicine:", "New Record", "None");

            var newRecord = new StudentRecord
            {
                StudentID = studentId,
                StudentName = name,
                Course = course,
                Symptoms = symptoms,
                Medicine = medicine,
                DateVisited = DateTime.Now
            };

            try
            {
                ClinicData.StudentRecords.Add(newRecord);
                ClinicData.SaveData();
                MessageBox.Show("Record added successfully!");
                RefreshDashboard();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }

            RefreshDashboard();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ClinicData.SaveData();
            MessageBox.Show("All data saved.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudentRecords.SelectedRows.Count > 0)
            {
                var record = (StudentRecord)dgvStudentRecords.SelectedRows[0].DataBoundItem;
                string choice = Microsoft.VisualBasic.Interaction.InputBox(
                    "1: Name, 2: Course, 3: Symptoms, 4: Medicine", "Update", "1");

                switch (choice)
                {
                    case "1": record.StudentName = Microsoft.VisualBasic.Interaction.InputBox("New Name:", "Update", record.StudentName); break;
                    case "2": record.Course = Microsoft.VisualBasic.Interaction.InputBox("New Course:", "Update", record.Course); break;
                    case "3": record.Symptoms = Microsoft.VisualBasic.Interaction.InputBox("New Symptoms:", "Update", record.Symptoms); break;
                    case "4": record.Medicine = Microsoft.VisualBasic.Interaction.InputBox("New Medicine:", "Update", record.Medicine); break;
                }

                ClinicData.SaveData();
                RefreshDashboard();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudentRecords.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Delete permanently?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var record = (StudentRecord)dgvStudentRecords.SelectedRows[0].DataBoundItem;
                    ClinicData.StudentRecords.Remove(record);
                    ClinicData.SaveData();
                    RefreshDashboard();
                }
            }
        }

        

        }
    }
