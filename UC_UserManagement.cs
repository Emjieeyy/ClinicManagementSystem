using System.Data;

namespace ClinicManagementSystem
{
    public partial class UC_UserManagement : UserControl
    {
        public UC_UserManagement()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            dataGridView1.Rows.Clear();
            DataTable dt = DatabaseHelper.GetAllUsers();

            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(
                    row["UserID"],
                    row["Username"],
                    row["FullName"],
                    row["Role"],
                    row["Email"],
                    row["Status"]
                );
            }
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            AddEditUserForm addForm = new AddEditUserForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void editUserBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UserID"].Value);
                string username = dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString()!;
                string fullName = dataGridView1.SelectedRows[0].Cells["FullName"].Value.ToString()!;
                string role = dataGridView1.SelectedRows[0].Cells["Role"].Value.ToString()!;
                string email = dataGridView1.SelectedRows[0].Cells["Email"].Value.ToString()!;
                string status = dataGridView1.SelectedRows[0].Cells["Status"].Value.ToString()!;

                AddEditUserForm editForm = new AddEditUserForm(userId, username, fullName, role, email, status);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers();
                }
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
                    int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UserID"].Value);
                    if (DatabaseHelper.DeleteUser(userId))
                    {
                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers();
                    }
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
