using ClinicManagementSystem.Data;
using ClinicManagementSystem.Models;
using System;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class UC_AddInformation1 : UserControl
    {
        public UC_AddInformation1()
        {
            InitializeComponent();
        }

        private void SaveRecordsbt_Click(object sender, EventArgs e)
        {
            // --- VALIDATIONS ---
            if (string.IsNullOrWhiteSpace(StudentID.Text))
            {
                MessageBox.Show("Student ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                StudentID.Focus();
                return;
            }

            if (!long.TryParse(StudentID.Text, out _))
            {
                MessageBox.Show("Student ID must contain numbers only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                StudentID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(StudentNametxt.Text))
            {
                MessageBox.Show("Student Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                StudentNametxt.Focus();
                return;
            }

            if (CourseComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CourseComboBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(SymptomsTxt.Text))
            {
                MessageBox.Show("Please enter symptoms.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SymptomsTxt.Focus();
                return;
            }

            // --- SAVING DATA ---
            try
            {
                // We no longer create the StudentRecord object manually here.
                // We call ClinicService, which handles the running time and logic.
                ClinicService.AddOrUpdateConsultation(
                    StudentID.Text.Trim(),
                    StudentNametxt.Text.Trim(),
                    CourseComboBox.SelectedItem?.ToString() ?? "N/A",
                    SymptomsTxt.Text.Trim(),
                    "",      // Medicine (blank for now)
                    "Staff"   // Role
                );

                MessageBox.Show("Medical record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save record: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clearbt_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            StudentID.Clear();
            StudentNametxt.Clear();
            SymptomsTxt.Clear();

            if (CourseComboBox.Items.Count > 0)
                CourseComboBox.SelectedIndex = -1;

            StudentID.Focus();
        }

        private void StudentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StudentNametxt.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void StudentNametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CourseComboBox.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void CourseComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SymptomsTxt.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void SymptomsTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveRecordsbt_Click(null, null);
                e.SuppressKeyPress = true;
            }
        }
    }
}