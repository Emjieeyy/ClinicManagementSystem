using ClinicManagementSystem.Data;
using ClinicManagementSystem.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class UC_AddInformation1 : UserControl
    {
        // Use the specific Windows Forms Timer to avoid errors
        private System.Windows.Forms.Timer clockTimer;
        public UC_AddInformation1()
        {
            InitializeComponent();

            // --- SETUP LIVE CLOCK ---
            clockTimer = new System.Windows.Forms.Timer();
            clockTimer.Interval = 1000; // Update every 1 second
            clockTimer.Tick += (s, e) =>
            {
                // Make sure you have a label named lblTimestamp on your UI!
                lblTimestamp.Text = "Visit Time: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            };
            clockTimer.Start();

            // --- SESSION LOGIC: Lock ID but allow Name typing ---
            if (SessionManager.Role == "Student")
            {
                // Auto-populate ID from Login Session
                StudentID.Text = SessionManager.CurrentID;

                // Lock the ID so they can't change their identity
                StudentID.ReadOnly = true;
                StudentID.BackColor = Color.LightGray; // Visual cue that it's locked

                // Allow them to type their name
                StudentNametxt.ReadOnly = false;
                StudentNametxt.BackColor = Color.White; // Visual cue that it's editable

                // Pre-fill the name from session, but they can edit/clear it
                StudentNametxt.Text = SessionManager.CurrentName;
            }
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
                ClinicService.AddOrUpdateConsultation(
                    StudentID.Text.Trim(),
                    StudentNametxt.Text.Trim(),
                    CourseComboBox.SelectedItem?.ToString() ?? "N/A",
                    SymptomsTxt.Text.Trim(),
                    "",
                    SessionManager.Role
                );

                MessageBox.Show("Medical record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Force data refresh in the main data list
                ClinicData.LoadData();

                // Clear the form and reset focus
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
            // 1. Clear the inputs
            SymptomsTxt.Clear();
            StudentNametxt.Clear(); // Now automatically clears the name after save

            // 2. Clear Course selection
            if (CourseComboBox.Items.Count > 0)
                CourseComboBox.SelectedIndex = -1;

            // 3. Role-based Focus and ID logic
            if (SessionManager.Role == "Student")
            {
                // We keep the StudentID visible because it is locked
                StudentNametxt.Focus(); // Return focus to Name for the next entry
            }
            else
            {
                // For Staff/Admin, we clear the ID too
                StudentID.Clear();
                StudentID.Focus();
            }
        }

        // --- KEYDOWN EVENTS ---
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

        private void UC_AddInformation1_Load(object sender, EventArgs e)
        {

        }
    }
}