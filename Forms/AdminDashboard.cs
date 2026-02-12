using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicManagementSystem.Models;
using ClinicManagementSystem.Data;
using System.IO;
using Newtonsoft.Json;

namespace ClinicManagementSystem.Forms
{
    public partial class AdminDashboard : Form
    {
        UserRepository repo = new UserRepository();
        List<User> userList = new List<User>();
        string logFilePath = "audit_logs.json";

        public AdminDashboard()
        {
            InitializeComponent();
            SetupFilterComboBox();
            RefreshUserGrid();
            LoadAuditLogs();
            UpdateRecentLogsCount();
        }

        private void SetupFilterComboBox()
        {
            cmbFilterActivity.Items.Clear();
            cmbFilterActivity.Items.AddRange(new object[] {
                "All Activities",
                "Authentication",
                "User Management",
                "Navigation"
            });
            cmbFilterActivity.SelectedIndex = 0;
        }

        private void RefreshUserGrid()
        {
            userList = repo.LoadUsers();
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = userList;
            TotalUserlabel_0.Text = userList.Count.ToString();
        }

        private void LoadAuditLogs(string searchTerm = "", string activityFilter = "All Activities")
        {
            if (!File.Exists(logFilePath))
            {
                dgvAuditLogs.DataSource = null;
                return;
            }

            var json = File.ReadAllText(logFilePath);
            var logs = JsonConvert.DeserializeObject<List<AuditLog>>(json) ?? new List<AuditLog>();

            if (activityFilter != "All Activities")
            {
                logs = logs.Where(l =>
                    l.Activity != null &&
                    l.Activity.Equals(activityFilter, StringComparison.OrdinalIgnoreCase)
                ).ToList();
            }

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = searchTerm.ToLower();
                logs = logs.Where(l =>
                    (l.Email?.ToLower().Contains(searchTerm) ?? false) ||
                    (l.Description?.ToLower().Contains(searchTerm) ?? false) ||
                    (l.Activity?.ToLower().Contains(searchTerm) ?? false) ||
                    (l.Status?.ToLower().Contains(searchTerm) ?? false)
                ).ToList();
            }

            dgvAuditLogs.AutoGenerateColumns = false;
            dgvAuditLogs.DataSource = null;
            dgvAuditLogs.DataSource = logs
                .OrderByDescending(l => l.Timestamp)
                .ToList();
        }

        private void UpdateRecentLogsCount()
        {
            if (File.Exists(logFilePath))
            {
                var json = File.ReadAllText(logFilePath);
                var logs = JsonConvert.DeserializeObject<List<AuditLog>>(json) ?? new List<AuditLog>();
                RecentLogs_label_0.Text = logs.Count.ToString();
            }
            else
            {
                RecentLogs_label_0.Text = "0";
            }
        }

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
                Email = "admin@clinic.com",
                Activity = activity,
                Description = description,
                Status = status
            });

            File.WriteAllText(logFilePath,
                JsonConvert.SerializeObject(logs, Formatting.Indented));

            LoadAuditLogs(Tab2_Searchtxtbx.Text, cmbFilterActivity.Text);
            UpdateRecentLogsCount();
        }

        private void cmbFilterActivity_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadAuditLogs(Tab2_Searchtxtbx.Text, cmbFilterActivity.Text);
        }

        private void Tab2_Seachbtn_Click(object sender, EventArgs e)
        {
            LoadAuditLogs(Tab2_Searchtxtbx.Text, cmbFilterActivity.Text);
        }

        // -------------------------------
        // AUTO RESET WHEN SEARCH CLEARED
        // -------------------------------
        private void Tab2_Searchtxtbx_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Tab2_Searchtxtbx.Text))
            {
                LoadAuditLogs("", cmbFilterActivity.Text);
            }
        }

        // -------------------------------
        // REFRESH BUTTON
        // -------------------------------
        private void Refreshbt_Click(object sender, EventArgs e)
        {
            Tab2_Searchtxtbx.Clear();
            cmbFilterActivity.SelectedIndex = 0;
            LoadAuditLogs();
            UpdateRecentLogsCount();

            MessageBox.Show("Logs updated successfully!",
                "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // -------------------------------
        // CLEAR LOGS
        // -------------------------------
        private void Tab2_ClearLogsbt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear history?", "Warning",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                File.WriteAllText(logFilePath, "[]");
                LoadAuditLogs();
                UpdateRecentLogsCount();
            }
        }

        // -------------------------------
        // NAVIGATION
        // -------------------------------
        private void UserManagementbtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            RecordAction("Navigation", "Admin viewed User Management", "Success");
        }

        private void AuditLogsbtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            RecordAction("Navigation", "Admin viewed Audit Logs", "Success");
        }

        // -------------------------------
        // LOGOUT
        // -------------------------------
        private void hopeRoundButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RecordAction("Authentication", "Admin logged out", "Success");
                this.Hide();
                new Login().Show();
            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            PerformUserSearch();
        }

        private void PerformUserSearch()
        {
            string term = txtSearchTab1.Text.Trim();

            if (string.IsNullOrWhiteSpace(term))
            {
                // Show all users when search is empty
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = userList;
                return;
            }

            string lowerTerm = term.ToLower();

            var results = userList.Where(u =>
                (u.UserID?.ToLower().Contains(lowerTerm) ?? false) ||
                (u.Name?.ToLower().Contains(lowerTerm) ?? false) ||
                (u.Email?.ToLower().Contains(lowerTerm) ?? false) ||
                (u.Role?.ToLower().Contains(lowerTerm) ?? false)
            ).ToList();

            dgvUsers.DataSource = null;
            dgvUsers.DataSource = results;
        }

        private void txtSearchTab1_TextChanged_1(object sender, EventArgs e)
        {
            PerformUserSearch();
        }

        private void RefreshUsersBtn_Click(object sender, EventArgs e)
        {
            txtSearchTab1.Clear();
            RefreshUserGrid();
            MessageBox.Show("User list refreshed successfully!",
                "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
