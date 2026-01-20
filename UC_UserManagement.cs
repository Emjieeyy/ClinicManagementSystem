namespace ClinicManagementSystem
{
    public partial class UC_UserManagement : UserControl
    {
        public UC_UserManagement()
        {
            InitializeComponent();
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            // Add sample data to the DataGridView
            dataGridView1.Rows.Add("001", "John Doe", "Clinic Staff", "john.doe@clinic.com", "Active");
            dataGridView1.Rows.Add("002", "Jane Smith", "Admin", "jane.smith@clinic.com", "Active");
            dataGridView1.Rows.Add("003", "Mike Johnson", "Student", "mike.j@student.edu", "Active");
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add User functionality - To be implemented", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editUserBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                MessageBox.Show("Edit User functionality - To be implemented", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a user to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this user?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
