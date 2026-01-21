namespace ClinicManagementSystem
{
    public partial class AddEditUserForm : Form
    {
        private int userId = 0;
        private bool isEditMode = false;

        // Constructor for Add mode
        public AddEditUserForm()
        {
            InitializeComponent();
            this.Text = "Add New User";
            isEditMode = false;
        }

        // Constructor for Edit mode
        public AddEditUserForm(int userId, string username, string fullName, string role, string email, string status)
        {
            InitializeComponent();
            this.Text = "Edit User";
            this.userId = userId;
            isEditMode = true;

            usernameTextBox.Text = username;
            usernameTextBox.Enabled = false; // Username cannot be changed
            fullNameTextBox.Text = fullName;
            roleComboBox.SelectedItem = role;
            emailTextBox.Text = email;
            statusComboBox.SelectedItem = status;
            passwordTextBox.Enabled = false;
            passwordTextBox.Text = "********";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                MessageBox.Show("Please enter username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isEditMode && string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("Please enter password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(fullNameTextBox.Text))
            {
                MessageBox.Show("Please enter full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (roleComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                MessageBox.Show("Please enter email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save or Update user
            bool success = false;

            if (isEditMode)
            {
                // Update existing user
                success = DatabaseHelper.UpdateUser(
                    userId,
                    usernameTextBox.Text.Trim(),
                    fullNameTextBox.Text.Trim(),
                    roleComboBox.SelectedItem.ToString()!,
                    emailTextBox.Text.Trim(),
                    statusComboBox.SelectedItem.ToString()!
                );

                if (success)
                {
                    MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DatabaseHelper.AddAuditLog("admin", "User Management", $"Updated user: {usernameTextBox.Text}", "Success");
                }
            }
            else
            {
                // Add new user
                success = DatabaseHelper.AddUser(
                    usernameTextBox.Text.Trim(),
                    passwordTextBox.Text.Trim(),
                    fullNameTextBox.Text.Trim(),
                    roleComboBox.SelectedItem.ToString()!,
                    emailTextBox.Text.Trim()
                );

                if (success)
                {
                    MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DatabaseHelper.AddAuditLog("admin", "User Management", $"Added new user: {usernameTextBox.Text}", "Success");
                }
            }

            if (success)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
