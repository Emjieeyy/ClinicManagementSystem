using ClinicManagementSystem.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
            RefreshDashboard();
        }

        public void RefreshDashboard()
        {
            // 1. Calculate Today's Total
            int todayCount = ClinicData.StudentRecords
                .Count(r => r.DateVisited.Date == DateTime.Today);

            // 2. Update your Label named "Total_0"
            Total_0.Text = todayCount.ToString();

            // 3. Connect the table to the shared data list
            // We clear it first to force a fresh bind
            dgvStudentRecords.DataSource = null;

            // --- THE BULLETPROOF FIX ---
            // We tell the grid: "Wait until you are 100% finished building columns, then run this formatting."
            dgvStudentRecords.DataBindingComplete += dgvStudentRecords_DataBindingComplete;

            dgvStudentRecords.DataSource = ClinicData.StudentRecords;
        }

        // This event only fires AFTER the columns physically exist in memory
        private void dgvStudentRecords_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvStudentRecords.Columns.Contains("DateVisited"))
            {
                // 1. Fix the width and format first
                dgvStudentRecords.Columns["DateVisited"].Width = 160;
                dgvStudentRecords.Columns["DateVisited"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";

                // 2. REORDER COLUMNS (0 is far left, 5 is far right)
                // This puts Medicine exactly between Symptoms and Date
                dgvStudentRecords.Columns["StudentID"].DisplayIndex = 0;
                dgvStudentRecords.Columns["StudentName"].DisplayIndex = 1;
                dgvStudentRecords.Columns["Course"].DisplayIndex = 2;
                dgvStudentRecords.Columns["Symptoms"].DisplayIndex = 3;
                dgvStudentRecords.Columns["Medicine"].DisplayIndex = 4; // Right beside Symptoms
                dgvStudentRecords.Columns["DateVisited"].DisplayIndex = 5; // At the end
            }

            // Remove the event handler to prevent loops
            dgvStudentRecords.DataBindingComplete -= dgvStudentRecords_DataBindingComplete;
        }

        private void hopeRoundButton8_Click(object sender, EventArgs e)
        {
            RefreshDashboard();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudentRecords.SelectedRows.Count > 0)
            {
                // Get the ID of the selected row
                string selectedId = dgvStudentRecords.SelectedRows[0].Cells["StudentID"].Value.ToString();

                // Find the record in the shared list
                var record = ClinicData.StudentRecords.FirstOrDefault(r => r.StudentID == selectedId);

                if (record != null)
                {
                    // Use a simple InputBox to get the medicine name
                    string prescribedMed = Microsoft.VisualBasic.Interaction.InputBox(
                        "Prescribe medicine for " + record.StudentName, "Update Record", record.Medicine);

                    if (!string.IsNullOrWhiteSpace(prescribedMed))
                    {
                        record.Medicine = prescribedMed; // Save to the record
                        RefreshDashboard(); // Update grid and "Total_0" label
                        MessageBox.Show("Medicine prescribed successfully!");
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudentRecords.SelectedRows.Count > 0)
            {
                var confirm = MessageBox.Show("Delete this record permanently?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    string id = dgvStudentRecords.SelectedRows[0].Cells["StudentID"].Value.ToString();
                    var record = ClinicData.StudentRecords.FirstOrDefault(r => r.StudentID == id);

                    if (record != null)
                    {
                        ClinicData.StudentRecords.Remove(record); // Remove from shared data
                        RefreshDashboard(); // Updates "Total_0" and Grid
                    }
                }
            }
        }
    }
}
    
