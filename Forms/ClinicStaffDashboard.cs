using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using ClinicManagementSystem.Models;

namespace ClinicManagementSystem
{
    public partial class ClinicStaffDashboard : Form
    {
        string logFilePath = "audit_logs.json";

        public ClinicStaffDashboard()
        {
            InitializeComponent();
            showPage(new UC_Home());
        }

        // --- AUDIT LOGGING TOOL ---
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
                Email = "Clinic Staff", // Tracks that a staff member did the action
                Activity = activity,
                Description = description,
                Status = status
            });

            File.WriteAllText(logFilePath, JsonConvert.SerializeObject(logs, Formatting.Indented));
        }

        // Switcher for User Controls
        public void showPage(Control Page)
        {
            mainPanel.Controls.Clear();
            Page.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(Page);
        }

        private void inventorybt_Click(object sender, EventArgs e)
        {
            showPage(new UC_Inventory());
            RecordAction("Navigation", "Staff viewed Inventory", "Success");
        }

        private void hopeRoundButton1_Click(object sender, EventArgs e)
        {
            showPage(new UC_Home());
        }

        private void hopeRoundButton3_Click(object sender, EventArgs e)
        {
            showPage(new UC_Reports());
            RecordAction("Navigation", "Staff viewed Reports", "Success");
        }

        // --- LOGOUT BUTTON ---

        private void hopeRoundButton4_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Change "Logout" to "Authentication"
                RecordAction("Authentication", "Clinic Staff logged out", "Success");

                this.Hide();
                new Login().Show();
            }
        }
    }
    }
