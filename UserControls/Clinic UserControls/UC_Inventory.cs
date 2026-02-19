using ClinicManagementSystem.Data;
using ClinicManagementSystem.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class UC_Inventory : UserControl
    {
        public const int LowStockThreshold = 3;

        public UC_Inventory()
        {
            InitializeComponent();

            // Grid basic behavior
            dtgInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgInventory.MultiSelect = false;
            dtgInventory.ReadOnly = false;
            dtgInventory.AllowUserToAddRows = false; // Prevents empty "ghost" rows
            dtgInventory.EnableHeadersVisualStyles = false;

            // Apply styles AFTER data binding
            dtgInventory.DataBindingComplete += DtgInventory_DataBindingComplete;

            // Fix invisible text while editing cells
            dtgInventory.EditingControlShowing += (s, e) =>
            {
                if (e.Control is TextBox tb)
                {
                    tb.ForeColor = Color.Black;
                    tb.BackColor = Color.White;
                }
            };

            InventoryData.LoadFromJson();
            RefreshInventory();
        }

        // ----------------------------
        // DATA LOADING & REFRESH
        // ----------------------------
        public void RefreshInventory()
        {
            // 1. PULL DATA FROM CLINICDATA (The Student Records source)
            // This counts students who visited today, exactly like your Staff Dashboard does
            int todayCount = ClinicData.StudentRecords.Count(r => r.DateVisited.Date == DateTime.Today);

            // 2. UPDATE THE CORRECT LABEL NAME
            // We are now using 'Inventory_label_0' as identified in your designer
            Inventory_label_0.Text = todayCount.ToString();

            // 3. REFRESH THE INVENTORY GRID
            dtgInventory.DataSource = null;
            if (InventoryData.InventoryItems != null)
            {
                dtgInventory.DataSource = InventoryData.InventoryItems;
            }

            // 4. UPDATE ALERTS AND VISUALS
            UpdateLowInventoryAlert();
            dtgInventory.Invalidate();

            if (UC_Home.Instance != null)
            {
                // Tell the dashboard to reload data from the JSON file you just saved
                InventoryData.LoadFromJson();

                // Tell the dashboard to update its red button
                UC_Home.Instance.UpdateLowInventoryAlert();

            }
        }
        // ----------------------------
        // ALL STYLING GOES HERE
        // ----------------------------
        private void DtgInventory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Set consistent colors from UC_Home
            dtgInventory.DefaultCellStyle.BackColor = Color.White;
            dtgInventory.DefaultCellStyle.ForeColor = Color.Black;
            dtgInventory.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dtgInventory.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Header styling
            dtgInventory.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dtgInventory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Row-specific styling for Low Stock
            foreach (DataGridViewRow row in dtgInventory.Rows)
            {
                if (row.DataBoundItem is InventoryItems item)
                {
                    if ((item.Quantity ?? 0) <= LowStockThreshold)
                    {
                        // Highlighting logic for danger items
                        row.DefaultCellStyle.BackColor = Color.MistyRose;
                        row.DefaultCellStyle.ForeColor = Color.DarkRed;
                        row.DefaultCellStyle.SelectionBackColor = Color.IndianRed;
                        row.DefaultCellStyle.SelectionForeColor = Color.White;
                    }
                    else
                    {
                        // Ensure normal rows stay black
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }

        // ----------------------------
        // BUTTONS (Updated Logic)
        // ----------------------------
        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            dtgInventory.EndEdit();

            int newId = InventoryData.InventoryItems.Any()
                ? InventoryData.InventoryItems.Max(i => i.ItemId ?? 0) + 1
                : 1;

            InventoryData.InventoryItems.Add(new InventoryItems
            {
                ItemId = newId,
                ItemName = "New Item",
                Quantity = 0,
                ExpiryDate = DateTime.Now.AddYears(1)
            });

            InventoryData.SaveToJson();
            RefreshInventory();
        }

        // MERGED: This now handles both Add and Deduct
        private void UpdateStockBtn_Click(object sender, EventArgs e)
        {
            dtgInventory.EndEdit();
            if (dtgInventory.CurrentRow == null)
            {
                MessageBox.Show("Please select an item first.");
                return;
            }

            var item = dtgInventory.CurrentRow.DataBoundItem as InventoryItems;
            if (item == null) return;

            string input = Microsoft.VisualBasic.Interaction.InputBox(
                $"Current Stock: {item.Quantity ?? 0}\n\nEnter amount to add (use negative '-' to deduct):",
                "Update Stock",
                "0");

            if (int.TryParse(input, out int changeValue))
            {
                int newTotal = (item.Quantity ?? 0) + changeValue;

                // Safety Check: Don't allow stock to go below zero
                if (newTotal < 0)
                {
                    MessageBox.Show("Deduction failed: Stock cannot be negative!");
                    return;
                }

                item.Quantity = newTotal;
                InventoryData.SaveToJson();
                RefreshInventory();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            dtgInventory.EndEdit();
            InventoryData.SaveToJson();
            MessageBox.Show("Inventory successfully saved!");
            RefreshInventory();
        }

        private void DeleteItembtn_Click(object sender, EventArgs e)
        {
            if (dtgInventory.SelectedRows.Count > 0)
            {
                var confirm = MessageBox.Show("Delete this item permanently?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    var item = (InventoryItems)dtgInventory.SelectedRows[0].DataBoundItem;
                    InventoryData.InventoryItems.Remove(item);
                    InventoryData.SaveToJson();
                    RefreshInventory();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        // ----------------------------
        // SEARCH & ALERTS
        // ----------------------------
        private void PerformInventorySearch()
        {
            string search = SearchTxt.Text.Trim().ToLower();

            var sourceList = InventoryData.InventoryItems;

            if (string.IsNullOrEmpty(search) || search == "search records...")
            {
                dtgInventory.DataSource = sourceList.ToList();
            }
            else
            {
                var filtered = sourceList.Where(i =>
                    (i.ItemId?.ToString().Contains(search) ?? false) ||
                    (i.ItemName?.ToLower().Contains(search) ?? false) ||
                    (i.Quantity?.ToString().Contains(search) ?? false)
                ).ToList();

                dtgInventory.DataSource = filtered;
            }

        }
        private void hopeRoundButton9_Click(object sender, EventArgs e)
        {
            PerformInventorySearch();
        }

        private void SearchTxt_Click(object sender, EventArgs e)
        {
        }

        public void UpdateLowInventoryAlert()
        {
            int lowCount = InventoryData.InventoryItems
                .Count(i => (i.Quantity ?? 0) <= LowStockThreshold);

            LowInvAlertBtn.ButtonType = lowCount > 0
                ? ReaLTaiizor.Util.HopeButtonType.Danger
                : ReaLTaiizor.Util.HopeButtonType.Primary;

            LowInvAlertBtn.Text = lowCount > 0
                ? $"      Low Inventory ({lowCount})"
                : "      Low Inventory";
        }

        public void HighlightLowStock()
        {
            RefreshInventory();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LowInvAlertBtn_Click(object sender, EventArgs e)
        {
            var lowStockItems = InventoryData.InventoryItems
                .Where(item => (item.Quantity ?? 0) <= LowStockThreshold)
                .ToList();

            if (lowStockItems.Count == 0)
            {
                MessageBox.Show("No items with low stock.");
                return;
            }

            var firstLowItem = lowStockItems.First();
            foreach (DataGridViewRow row in dtgInventory.Rows)
            {
                if (row.IsNewRow) continue;

                var item = row.DataBoundItem as InventoryItems;
                if (item != null && item.ItemId == firstLowItem.ItemId)
                {
                    dtgInventory.ClearSelection();
                    row.Selected = true;
                    dtgInventory.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }

            MessageBox.Show($"There are {lowStockItems.Count} item(s) with low stock!");
        }

        private void dtgInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {

            PerformInventorySearch();
        }
    }
}
