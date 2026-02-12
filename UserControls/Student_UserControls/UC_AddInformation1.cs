using ClinicManagementSystem.Data;
using ClinicManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class UC_AddInformation1 : UserControl
    {
        public UC_AddInformation1()
        {
            InitializeComponent();
            // Note: Ensure SaveRecordsbt and Clearbt have their 'Click' events 
            // linked to these methods in the Visual Studio Properties window.
        }

        private void SaveRecordsbt_Click(object sender, EventArgs e)
        {
            // 1. Validation Logic
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

            if (dateTimePicker1.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Date Visited cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker1.Focus();
                return;
            }

            try
            {
                var record = new StudentRecord
                {
                    StudentID = StudentID.Text.Trim(),
                    StudentName = StudentNametxt.Text.Trim(),
                    Course = CourseComboBox.SelectedItem?.ToString() ?? "N/A",
                    Symptoms = SymptomsTxt.Text.Trim(),
                    DateVisited = dateTimePicker1.Value.Date
                };

                ClinicData.StudentRecords.Add(record);
                ClinicData.SaveData();

                MessageBox.Show("Medical record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the form for the next entry
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
            // Reset all input fields
            StudentID.Clear();
            StudentNametxt.Clear();
            SymptomsTxt.Clear();

            if (CourseComboBox.Items.Count > 0)
                CourseComboBox.SelectedIndex = -1;

            dateTimePicker1.Value = DateTime.Now;

            // Set focus back to the first field
            StudentID.Focus();
        }
    }
}