using ClinicManagementSystem.Data;
using ClinicManagementSystem.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class StudentDashboard : Form
    {
        string logFilePath = "audit_logs.json";

        public StudentDashboard()
        {
            InitializeComponent();
            ShowPage(new UC_StudentRecords());
            this.FormClosing += StudentDashboard_FormClosing; // Save on exit
        }

        private void StudentDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClinicData.SaveData(); // ✅ Save all data
        }

        // --- STEP 1: ADD THE METHOD HERE ---
        // This is the "Tool" that writes to your JSON file
        private void RecordAction(string activity, string description, string status)
        {
            List<AuditLog> logs = new List<AuditLog>();

            if (File.Exists(logFilePath))
            {
                var json = File.ReadAllText(logFilePath);
                logs = JsonConvert.DeserializeObject<List<AuditLog>>(json) ?? new List<AuditLog>();
            }

            logs.Add(new AuditLog
            {
                Timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Email = "Student User",
                Activity = activity,
                Description = description,
                Status = status
            });

            File.WriteAllText(logFilePath, JsonConvert.SerializeObject(logs, Formatting.Indented));
        }
        public void ShowPage(UserControl page)
        {
            student_UC_container.Controls.Clear();
            page.Dock = DockStyle.Fill;
            student_UC_container.Controls.Add(page);

            // Add these two lines to "wake up" the UserControl
            page.BringToFront();
            page.Focus();
        }

        private void hopeRoundButton3_Click(object sender, EventArgs e)
        {
            ShowPage(new UC_AddInformation1());
        }

        private void hopeRoundButton2_Click(object sender, EventArgs e)
        {
            ShowPage(new UC_UpdateInfomation());
        }

        private void myRecordsbt_Click(object sender, EventArgs e)
        {
            ShowPage(new UC_StudentRecords());
        }

        // --- STEP 2: USE THE METHOD IN YOUR LOGOUT BUTTON ---
        private void hopeRoundButton4_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Change "Logout" to "Authentication" to match your filter
                RecordAction("Authentication", "Student logged out", "Success");

                this.Hide();
                new Login().Show();
                }
        }
    }
}