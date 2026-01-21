using System.Data;

namespace ClinicManagementSystem
{
    public partial class UC_AuditLogs : UserControl
    {
        public UC_AuditLogs()
        {
            InitializeComponent();
            filterComboBox.SelectedIndex = 0;
            LoadAuditLogs();
        }

        private void LoadAuditLogs()
        {
            dataGridView1.Rows.Clear();
            DataTable dt = DatabaseHelper.GetAuditLogs();

            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(
                    Convert.ToDateTime(row["Timestamp"]).ToString("yyyy-MM-dd HH:mm:ss"),
                    row["Username"],
                    row["Activity"],
                    row["Description"],
                    row["Status"]
                );
            }
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
