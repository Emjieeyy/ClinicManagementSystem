using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClinicManagementSystem.Models;
using ClinicManagementSystem.Data;

namespace ClinicManagementSystem
{
    public partial class ClinicStaffDashboard : Form
    {// ONLY these two. Delete the other homePage/inventoryPage lines.
        public UC_Home homeControl;
        public UC_Inventory inventoryControl;


        public ClinicStaffDashboard()
        {
            InitializeComponent();
            // 2. NOW create the pages
            homeControl = new UC_Home();
            inventoryControl = new UC_Inventory();

            InventoryData.LoadFromJson();

            // 3. Show the page
            showPage(homeControl);

            this.Load += ClinicStaffDashboard_Load;
        }

        private void ClinicStaffDashboard_Load(object sender, EventArgs e)
        {
            RefreshLowInventoryEverywhere();
        }

        // Updated to use the master inventoryControl
        public void ShowInventoryPage()
        {
            showPage(inventoryControl);
            inventoryControl.HighlightLowStock();
        }

        public void RefreshLowInventoryEverywhere()
        {
            // Sync the red button status on both pages
            homeControl.UpdateLowInventoryAlert();
            inventoryControl.UpdateLowInventoryAlert();
        }

        public void showPage(Control Page)
        {
            // Only swap if the panel doesn't already have this specific page
            if (!mainPanel.Controls.Contains(Page))
            {
                mainPanel.Controls.Clear();
                Page.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(Page);
            }

            // Refresh logic whenever a page is shown
            if (Page is UC_Home home)
            {
                home.RefreshDashboard();
                home.UpdateLowInventoryAlert(); // Ensure button turns red
            }
            else if (Page is UC_Inventory inventory)
            {
                inventory.RefreshInventory();
                inventory.UpdateLowInventoryAlert();
            }

            Page.BringToFront();
        }

        // --- BUTTON CLICKS (Fixed to stop using 'new') ---

        private void inventorybt_Click(object sender, EventArgs e)
        {
            showPage(inventoryControl);
        }

        private void ClinicStaffStudentRecordsbt_Click(object sender, EventArgs e)
        {
            // Use the same master instance
            showPage(homeControl);
        }

        private void reportbt_Click(object sender, EventArgs e)
        {
            // Reports doesn't need a master instance unless you want to save its state
            showPage(new UC_Reports());
        }

        private void ClinicLogOutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}