using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClinicManagementSystem.Models;
using ClinicManagementSystem.Data; // Added to access student records

namespace ClinicManagementSystem
{
    public partial class ClinicStaffDashboard : Form
    {
        public UC_Home homeControl;
        public UC_Inventory inventoryControl;
        UC_Home homePage = new UC_Home();
        UC_Inventory inventoryPage = new UC_Inventory();
        public ClinicStaffDashboard()
        {
            InitializeComponent();
            showPage(new UC_Home()); // Load the home screen with the grid

            InventoryData.LoadFromJson();
            showPage(new UC_Home()); // Load the home screen with the grid
            RefreshLowInventoryEverywhere();

            homeControl = new UC_Home();
            inventoryControl = new UC_Inventory();

            this.Load += ClinicStaffDashboard_Load;
        }
        private void ClinicStaffDashboard_Load(object sender, EventArgs e)
        {
            RefreshLowInventoryEverywhere();
        }
        public void ShowInventoryPage()
        {
            mainPanel.Controls.Clear(); // panel where UCs are displayed
            if (inventoryControl == null) inventoryControl = new UC_Inventory();
            mainPanel.Controls.Add(inventoryControl);
            inventoryControl.Dock = DockStyle.Fill;
        }

        public void RefreshLowInventoryEverywhere()
        {
            homeControl?.UpdateLowInventoryAlert();
            inventoryControl?.UpdateLowInventoryAlert();
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
            homePage.RefreshDashboard(); // Refresh it before showing
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



