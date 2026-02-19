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
            // 2. ADD THIS LINE: Initialize the instance
            Instance = this;

            InventoryData.LoadFromJson();

            // --- MANDATORY INITIAL DESIGN ---
            dgvStudentRecords.EnableHeadersVisualStyles = false; // Required for custom header colors
            dgvStudentRecords.BackgroundColor = Color.White;
            dgvStudentRecords.BorderStyle = BorderStyle.FixedSingle;
            dgvStudentRecords.RowHeadersVisible = false; // Removes the left arrow column

            dgvStudentRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentRecords.MultiSelect = false;
            dgvStudentRecords.ReadOnly = true;
            dgvStudentRecords.AllowUserToAddRows = false;

            // Wire up the styling event
            dgvStudentRecords.DataBindingComplete += DgvStudentRecords_DataBindingComplete;

            RefreshDashboard();
            this.Load += (s, e) => UpdateLowInventoryAlert();
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
            // 1. Temporarily unbind the event to stop styling logic from firing during the reset
            dgvStudentRecords.DataBindingComplete -= DgvStudentRecords_DataBindingComplete;

            try
            {
                int todayCount = ClinicData.StudentRecords.Count(r => r.DateVisited.Date == DateTime.Today);
                Total_0.Text = todayCount.ToString();

                // 2. Clear the source completely
                dgvStudentRecords.DataSource = null;
                dgvStudentRecords.Rows.Clear(); // Force clear any residual rows

                if (ClinicData.StudentRecords != null)
                {
                    // 3. Use a BindingSource for smoother transitions (Recommended)
                    dgvStudentRecords.DataSource = ClinicData.StudentRecords.ToList();
                }
            }
            finally
            {
                // 4. Re-bind the styling event and clean up
                dgvStudentRecords.DataBindingComplete += DgvStudentRecords_DataBindingComplete;
                dgvStudentRecords.ClearSelection();
                UpdateLowInventoryAlert();
            }
            ;
        }


        // --- BUTTON LOGIC ---

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

        public void UpdateLowInventoryAlert()
        {

            InventoryData.LoadFromJson();
            // Add "i.ItemName != "New Item"" so the count is the same on both screens
            int lowCount = InventoryData.InventoryItems
                .Count(i => i.ItemName != "New Item" && (i.Quantity ?? 0) <= LowStockThreshold);

            LowInvAlertBtn.ButtonType = lowCount > 0
                ? ReaLTaiizor.Util.HopeButtonType.Danger
                : ReaLTaiizor.Util.HopeButtonType.Primary;

            LowInvAlertBtn.Text = lowCount > 0
                ? $"      Low Inventory ({lowCount})"
                : "      Low Inventory";

            LowInvAlertBtn.Refresh();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ClinicData.SaveData();

            MessageBox.Show("All data saved.");
        }

        private void LowInvAlertBtn_Click(object sender, EventArgs e)
        {
            // 1. Find the main dashboard form
            var mainDashboard = this.ParentForm as ClinicStaffDashboard;

            if (mainDashboard != null)
            {
                // 2. Call your new public navigation method
                mainDashboard.ShowInventoryPage();

                // 3. Tell the inventory control to highlight the low stock items
                // Note: Ensure 'inventoryControl' is public in your Dashboard code
                if (mainDashboard.inventoryControl != null)
                {
                    mainDashboard.inventoryControl.HighlightLowStock();
                }
            }
        }

        

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            PerformStudentSearch();
        }
        private void PerformStudentSearch()
        {
            // 1. Get the term from textBox1
            string term = textBox1.Text.Trim().ToLower();

            // 2. Filter the data
            if (string.IsNullOrWhiteSpace(term))
            {
                // If empty, show everything
                dgvStudentRecords.DataSource = ClinicData.StudentRecords.ToList();
            }
            else
            {
                var results = ClinicData.StudentRecords.Where(r =>
                    (r.StudentID?.ToLower().Contains(term) ?? false) ||
                    (r.StudentName?.ToLower().Contains(term) ?? false) ||
                    (r.Course?.ToLower().Contains(term) ?? false) ||
                    (r.Symptoms?.ToLower().Contains(term) ?? false) ||
                    (r.Medicine?.ToLower().Contains(term) ?? false)
                ).ToList();

                dgvStudentRecords.DataSource = results;
            }

            // 3. Optional: Clear selection so the first row isn't yellow immediately
            dgvStudentRecords.ClearSelection();
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            PerformStudentSearch();
        }
    }
}
