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

        }

        private void hopeRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

