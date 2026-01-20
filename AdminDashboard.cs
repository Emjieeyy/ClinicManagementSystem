namespace ClinicManagementSystem
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            showPage(new UC_UserManagement());
        }

        // This is the switcher that swaps the user control pages
        public void showPage(Control Page)
        {
            mainPanel.Controls.Clear(); 
            Page.Dock = DockStyle.Fill; 
            mainPanel.Controls.Add(Page); 
        }

        private void homebt_Click(object sender, EventArgs e)
        {
            showPage(new UC_UserManagement());
        }

        private void settingsbt_Click(object sender, EventArgs e)
        {
            showPage(new UC_SystemSettings());
        }

        private void auditbt_Click(object sender, EventArgs e)
        {
            showPage(new UC_AuditLogs());
        }

        private void reportsbt_Click(object sender, EventArgs e)
        {
            showPage(new UC_Reports());
        }

        private void inventorybt_Click(object sender, EventArgs e)
        {
            showPage(new UC_Inventory());
        }

        private void logoutbt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?", 
                "Logout Confirmation", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login loginForm = new Login();
                loginForm.ShowDialog();
                this.Close();
            }
        }
    }
}
