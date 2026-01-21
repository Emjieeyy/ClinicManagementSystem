using System.Data;

namespace ClinicManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logintb_Click(object sender, EventArgs e)
        {

        }

        private void usernametb_Click(object sender, EventArgs e)
        {

        }

        private void showpasswordcb_CheckedChanged(object sender, EventArgs e)
        {
            // If the checkbox is checked, hide the password character 
            // to reveal the actual text.
            if (showpasswordcb.Checked)
            {
                passwordtb.UseSystemPasswordChar = false;
            }
            else
            {
                passwordtb.UseSystemPasswordChar = true;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginbt_Click(object sender, EventArgs e)
        {
            string username = usernametb.Text.Trim();
            string password = passwordtb.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernametb.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordtb.Focus();
                return;
            }

            // Authenticate user
            DataTable dt = DatabaseHelper.AuthenticateUser(username, password);

            if (dt.Rows.Count > 0)
            {
                // Login successful
                string role = dt.Rows[0]["Role"].ToString();
                string fullName = dt.Rows[0]["FullName"].ToString();

                // Add audit log
                DatabaseHelper.AddAuditLog(username, "Login", $"{fullName} logged in successfully", "Success");

                // Hide login form
                this.Hide();

                // Open appropriate dashboard based on role
                if (role == "Admin")
                {
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.ShowDialog();
                }
                else if (role == "Clinic Staff")
                {
                    ClinicStaffDashboard staffDashboard = new ClinicStaffDashboard();
                    staffDashboard.ShowDialog();
                }
                else if (role == "Student")
                {
                    StudentDashboard studentDashboard = new StudentDashboard();
                    studentDashboard.ShowDialog();
                }

                // Close login form after dashboard is closed
                this.Close();
            }
            else
            {
                // Login failed
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DatabaseHelper.AddAuditLog(username, "Login", "Failed login attempt", "Failed");
                passwordtb.Clear();
                passwordtb.Focus();
            }
        }

        private void hopeRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

