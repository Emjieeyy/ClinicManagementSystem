namespace ClinicManagementSystem
{
    public partial class ClinicStaffDashboard : Form
    {
        public ClinicStaffDashboard()
        {
            InitializeComponent();
            showPage(new UC_Home());
        }
        // This is the switcher that swaps the "tiles"
        public void showPage(Control Page)
        {
            mainPanel.Controls.Clear(); // Remove whatever is currently there
            Page.Dock = DockStyle.Fill; // Make the new page fit the whole space
            mainPanel.Controls.Add(Page); // Put the new page on the stage

        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bigLabel2_Click(object sender, EventArgs e)
        {

        }

        private void inventorybt_Click(object sender, EventArgs e)
        {
            showPage(new UC_Inventory());
        }

        private void hopeRoundButton1_Click(object sender, EventArgs e)
        {
            showPage(new UC_Home());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hopeRoundButton7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void hopeRoundButton3_Click(object sender, EventArgs e)
        {
            showPage(new UC_Reports());
        
    }
    }
}

