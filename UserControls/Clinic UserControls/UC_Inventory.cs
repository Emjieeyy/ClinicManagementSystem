using ClinicManagementSystem.Data;
using ClinicManagementSystem.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class UC_Inventory : UserControl
    {
        private BindingSource inventoryBinding = new BindingSource();

        public UC_Inventory()
        {
            InitializeComponent();

            SetupGrid();
            SetupStyle();

            // Load JSON FIRST
            InventoryData.LoadFromJson();

            // Bind ONCE only
            inventoryBinding.DataSource = InventoryData.InventoryItems;
            dtgInventory.DataSource = inventoryBinding;

            // REMOVED: The CurrentCellDirtyStateChanged block that was causing the 1-letter typing bug.
        }

        // ================= GRID SETUP =================

        private void SetupGrid()
        {
            dtgInventory.AutoGenerateColumns = false;
            dtgInventory.Columns.Clear();

            dtgInventory.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ItemId",
                HeaderText = "Item ID",
                Name = "ItemId"
            });

            dtgInventory.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ItemName",
                HeaderText = "Item Name",
                Name = "ItemName"
            });

            dtgInventory.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Quantity",
                HeaderText = "Quantity",
                Name = "Quantity"
            });

            dtgInventory.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ExpiryDate",
                HeaderText = "Expiry Date",
                Name = "ExpiryDate",
                DefaultCellStyle = new DataGridViewCellStyle() { Format = "yyyy-MM-dd" }
            });

            dtgInventory.AllowUserToAddRows = false;
            // Changing to EditOnKeystrokeOrF2 allows for a more natural typing experience
            dtgInventory.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
        }

        private void SetupStyle()
        {
            dtgInventory.DefaultCellStyle.BackColor = Color.White;
            dtgInventory.DefaultCellStyle.ForeColor = Color.Black;
            dtgInventory.DefaultCellStyle.SelectionBackColor = Color.LightBlue; // Changed for better visibility
            dtgInventory.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void UC_Inventory_Load(object sender, EventArgs e)
        {
            SearchTxt.Text = "Search Records...";
        }

        private void hopeRoundButton9_Click(object sender, EventArgs e)
        {
            FilterInventory();
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            // Fixed: Handle potential null ItemId by using ?? 0
            int newId = InventoryData.InventoryItems.Any()
                ? (InventoryData.InventoryItems.Max(i => i.ItemId) ?? 0) + 1
                : 1;

            InventoryData.InventoryItems.Add(new InventoryItems
            {
                ItemId = newId,
                ItemName = "New Item",
                Quantity = 0,
                ExpiryDate = DateTime.Now.AddYears(1)
            });
        }

        private void UpdateStockBtn_Click(object sender, EventArgs e)
        {
            if (dtgInventory.CurrentRow == null)
            {
                MessageBox.Show("Select an item first.");
                return;
            }

            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter quantity to ADD:", "Update Stock", "0");

            if (!int.TryParse(input, out int add) || add <= 0)
            {
                MessageBox.Show("Invalid input.");
                return;
            }

            var item = dtgInventory.CurrentRow.DataBoundItem as InventoryItems;
            if (item != null)
            {
                // Fixed: Handle nullable int with ?? 0
                item.Quantity = (item.Quantity ?? 0) + add;
            }
        }

        private void DeductStockBtn_Click(object sender, EventArgs e)
        {
            if (dtgInventory.CurrentRow == null)
            {
                MessageBox.Show("Select an item first.");
                return;
            }

            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter quantity to DEDUCT:", "Deduct Stock", "0");

            if (!int.TryParse(input, out int deduct) || deduct <= 0)
            {
                MessageBox.Show("Invalid input.");
                return;
            }

            var item = dtgInventory.CurrentRow.DataBoundItem as InventoryItems;

            if (item != null)
            {
                // Fixed: Handle nullable int with ?? 0
                int currentQty = item.Quantity ?? 0;
                if (deduct > currentQty)
                {
                    MessageBox.Show("Cannot deduct more than current quantity.");
                    return;
                }

                item.Quantity = currentQty - deduct;
            }
        }

        private bool ValidateRow(DataGridViewRow row)
        {
            // Validation updated to handle nullable types safely
            if (row.Cells["ItemId"].Value == null || string.IsNullOrEmpty(row.Cells["ItemId"].Value.ToString()))
                return false;

            if (row.Cells["ItemName"].Value == null || string.IsNullOrWhiteSpace(row.Cells["ItemName"].Value.ToString()))
                return false;

            if (row.Cells["Quantity"].Value == null || string.IsNullOrEmpty(row.Cells["Quantity"].Value.ToString()))
                return false;

            if (row.Cells["ExpiryDate"].Value == null || !DateTime.TryParse(row.Cells["ExpiryDate"].Value.ToString(), out _))
                return false;

            return true;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            dtgInventory.EndEdit();

            foreach (DataGridViewRow row in dtgInventory.Rows)
            {
                if (row.IsNewRow) continue;

                if (!ValidateRow(row))
                {
                    MessageBox.Show("Please fill all fields correctly.");
                    return;
                }
            }

            InventoryData.SaveToJson();
            MessageBox.Show("Inventory saved successfully!");
        }

        private void FilterInventory()
        {
            string search = SearchTxt.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(search) || search == "search records...")
            {
                inventoryBinding.DataSource = InventoryData.InventoryItems;
                return;
            }

            var filtered = InventoryData.InventoryItems
                .Where(i =>
                    (!string.IsNullOrEmpty(i.ItemName) && i.ItemName.ToLower().Contains(search)) ||
                    (i.ItemId != null && i.ItemId.ToString().Contains(search)))
                .ToList();

            inventoryBinding.DataSource = new BindingList<InventoryItems>(filtered);
        }

        private void SearchTxt_Click(object sender, EventArgs e)
        {
            if (SearchTxt.Text == "Search Records...")
                SearchTxt.Clear();
        }

        private void dtgInventory_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}