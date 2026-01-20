namespace ClinicManagementSystem
{
    public partial class UC_AuditLogs : UserControl
    {
        public UC_AuditLogs()
        {
            InitializeComponent();
            LoadAuditLogs();
        }

        private void LoadAuditLogs()
        {
            // Add sample audit log data
            dataGridView1.Rows.Add("2026-01-20 10:30:25", "john.doe", "Login", "User logged in successfully", "Success");
            dataGridView1.Rows.Add("2026-01-20 10:35:12", "jane.smith", "User Management", "Added new user: Mike Johnson", "Success");
            dataGridView1.Rows.Add("2026-01-20 11:15:45", "mike.johnson", "Inventory", "Updated inventory item: Bandages", "Success");
            dataGridView1.Rows.Add("2026-01-20 11:20:33", "john.doe", "Settings", "Modified system settings", "Success");
            dataGridView1.Rows.Add("2026-01-20 12:05:18", "jane.smith", "Backup", "Initiated system backup", "Success");
            dataGridView1.Rows.Add("2026-01-20 13:45:22", "admin", "Login", "Failed login attempt", "Failed");
            dataGridView1.Rows.Add("2026-01-20 14:10:55", "john.doe", "Reports", "Generated monthly report", "Success");
            dataGridView1.Rows.Add("2026-01-20 15:30:41", "mike.johnson", "Inventory", "Deleted inventory item", "Success");
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = filterComboBox.SelectedItem?.ToString() ?? "All Activities";
            
            if (filter == "All Activities")
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Visible = true;
                }
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Activity"].Value?.ToString() == filter)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.Trim().ToLower();
            
            if (string.IsNullOrEmpty(searchText))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Visible = true;
                }
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool found = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        found = true;
                        break;
                    }
                }
                row.Visible = found;
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadAuditLogs();
            filterComboBox.SelectedIndex = 0;
            searchTextBox.Clear();
            MessageBox.Show("Audit logs refreshed.", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Export functionality - To be implemented\nWould export to CSV or Excel format.", "Export Logs", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clearLogsBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to clear all audit logs? This action cannot be undone.",
                "Clear Audit Logs",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();
                MessageBox.Show("All audit logs have been cleared.", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
