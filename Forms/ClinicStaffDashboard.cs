using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClinicManagementSystem.Models;
using ClinicManagementSystem.Data; // Added to access student records

namespace ClinicManagementSystem
{
    public partial class ClinicStaffDashboard : Form
    {
        public ClinicStaffDashboard()
        {
            InitializeComponent();
            showPage(new UC_Home()); // Load the home screen with the grid
        }

        public void showPage(Control Page)
        {
            mainPanel.Controls.Clear();
            Page.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(Page);

            // If we are switching back to the Home page, refresh the "Total_0" label immediately
            if (Page is UC_Home homePage)
            {
                homePage.RefreshDashboard();
            }
        }

        // Navigation for Student Records (The View Button/Tab)

        private void inventorybt_Click(object sender, EventArgs e) => showPage(new UC_Inventory());

        private void ClinicStaffStudentRecordsbt_Click(object sender, EventArgs e)
        {
            showPage(new UC_Home());
        }

        private void reportbt_Click(object sender, EventArgs e)
        {
            showPage(new UC_Reports());
        }

        private void ClinicLogOutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
