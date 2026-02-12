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


        private void Tab2_Searchtxtbx_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Tab2_Searchtxtbx.Text))
            {
                LoadAuditLogs("", cmbFilterActivity.Text);
            }
        }


        private void Refreshbt_Click(object sender, EventArgs e)
        {
            Tab2_Searchtxtbx.Clear();
            cmbFilterActivity.SelectedIndex = 0;
            LoadAuditLogs();
            UpdateRecentLogsCount();

        }


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


        private void hopeRoundButton4_Click(object sender, EventArgs e)
        {
                RecordAction("Authentication", "Admin logged out", "Success");
                this.Hide();
                new Login().Show();
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

        private void AddUserbtn_Click(object sender, EventArgs e)
        {
            var users = repo.LoadUsers();
            int newIdInt = users.Any() ? users.Max(u => int.Parse(u.UserID)) + 1 : 1001;
            string nextId = newIdInt.ToString();

            string newName = Microsoft.VisualBasic.Interaction.InputBox("Enter Name:", "Add User " + nextId);
            if (string.IsNullOrEmpty(newName)) return;

            string newEmail = Microsoft.VisualBasic.Interaction.InputBox("Enter Email:", "Add User " + nextId);
            if (string.IsNullOrEmpty(newEmail)) return;

            string autoPassword = "User" + nextId;

            User newUser = new User
            {
                UserID = nextId,
                Name = newName,
                Email = newEmail,
                Role = "Student",
                Password = autoPassword,
                Status = "Offline"
            };

            users.Add(newUser);
            repo.SaveUsers(users);

            RecordAction("Add User", $"Created student: {newName} ({newEmail})", "Success");

            RefreshUserGrid();
            MessageBox.Show($"User {newName} added successfully!");
        }

        private void UpdateUserbtn_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                User selectedUser = (User)dgvUsers.SelectedRows[0].DataBoundItem;
                string oldName = selectedUser.Name;
                string newName = Microsoft.VisualBasic.Interaction.InputBox("Enter new name:", "Update User", selectedUser.Name);

                if (!string.IsNullOrEmpty(newName))
                {
                    selectedUser.Name = newName;
                    repo.SaveUsers(userList);

                    RecordAction("Update User", $"Changed name of {selectedUser.Email} from {oldName} to {newName}", "Success");

                    RefreshUserGrid();
                    MessageBox.Show("Update successful!");
                }
            }
            else
            {
                MessageBox.Show("Please select a full row first.");
            }
        }


        private void DeleteUserbtn_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Delete this user permanently?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    User selectedUser = (User)dgvUsers.SelectedRows[0].DataBoundItem;
                    string deletedEmail = selectedUser.Email;

                    userList.Remove(selectedUser);
                    repo.SaveUsers(userList);

                    RecordAction("Delete User", $"Permanently removed user: {deletedEmail}", "Success");

                    RefreshUserGrid();
                    MessageBox.Show("User deleted successfully!");
                }
            }
        }

        private void Tab2_Exportbtn_Click(object sender, EventArgs e)
        {
            if (dgvAuditLogs.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = $"AuditLogs_{DateTime.Now:yyyyMMdd_HHmm}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();

                        // 1. ADD THIS LINE: It tells Excel to use comma as the delimiter explicitly
                        sb.AppendLine("sep=,");

                        // 2. Get Column Headers
                        string[] headers = dgvAuditLogs.Columns.Cast<DataGridViewColumn>()
                                            .Select(column => $"\"{column.HeaderText}\"").ToArray();
                        sb.AppendLine(string.Join(",", headers));

                        // 3. Get Row Data
                        foreach (DataGridViewRow row in dgvAuditLogs.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                // We wrap values in quotes ("") to handle spaces and special characters better
                                string[] cells = row.Cells.Cast<DataGridViewCell>()
                                                 .Select(cell => $"\"{cell.Value?.ToString().Replace("\"", "\"\"")}\"").ToArray();
                                sb.AppendLine(string.Join(",", cells));
                            }
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

                        RecordAction("Export", $"Exported {dgvAuditLogs.Rows.Count} logs", "Success");
                        MessageBox.Show("Exported successfully! Tip: In Excel, double-click the top column borders to expand them.", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}

