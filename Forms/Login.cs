using ClinicManagementSystem.Data;
using ClinicManagementSystem.Forms;
using ClinicManagementSystem.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class Login : Form
    {
        string logFilePath = "audit_logs.json";

        public Login()
        {
            InitializeComponent();
            this.Load += Login_Load;
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = loginbt;
            txtEmail.Text = "please enter email";
            txtEmail.ForeColor = Color.Silver;
            txtPassword.Text = "please enter password";
            txtPassword.ForeColor = Color.Silver;
            txtPassword.UseSystemPasswordChar = false;
        }

        private void RecordAction(string email, string activity, string description, string status)
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
                Email = email,
                Activity = activity, // This will now consistently be "Authentication"
                Description = description,
                Status = status
            });

            File.WriteAllText(logFilePath, JsonConvert.SerializeObject(logs, Formatting.Indented));
        }

        private void loginbt_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (email == "please enter email" || password == "please enter password")
            {
                MessageBox.Show("Please enter your credentials.");
                return;
            }

            UserRepository repo = new UserRepository();
            var users = repo.LoadUsers();
            var user = users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                // Consistent category: Authentication
                RecordAction(user.Email, "Authentication", $"{user.Role} logged in successfully", "Success");

                this.Hide();

                switch (user.Role)
                {
                    case "Admin":
                        new AdminDashboard().Show();
                        break;
                    case "Staff":
                        new ClinicStaffDashboard().Show();
                        break;
                    case "Student":
                        new StudentDashboard().Show();
                        break;
                    default:
                        MessageBox.Show("User role not recognized.");
                        this.Show();
                        break;
                }
            }
            else
            {
                // Updated: Activity is now "Authentication" so the filter catches failed attempts too
                RecordAction(email, "Authentication", "Failed login attempt: Invalid credentials", "Failed");
                MessageBox.Show("Invalid Email or Password.");
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "please enter email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "please enter email";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "please enter password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "please enter password";
                txtPassword.ForeColor = Color.Silver;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void showpasswordcb_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "please enter password")
            {
                txtPassword.UseSystemPasswordChar = !showpasswordcb.Checked;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}