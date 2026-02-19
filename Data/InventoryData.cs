using ClinicManagementSystem.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;


namespace ClinicManagementSystem.Data
{
    internal class InventoryData
    {
        private static string jsonFilePath = "inventory.json";

        public static BindingList<InventoryItems> InventoryItems { get; private set; } = new BindingList<InventoryItems>();


        public static void LoadFromJson()
        {
            if (!File.Exists(jsonFilePath))
                return;

            try
            {
                string json = File.ReadAllText(jsonFilePath);

                if (string.IsNullOrWhiteSpace(json))
                    return;

                var list = JsonConvert.DeserializeObject<List<InventoryItems>>(json);

                InventoryItems.Clear();

                if (list != null)
                {
                    foreach (var item in list)
                        InventoryItems.Add(item);
                }
            }
            catch
            {
                MessageBox.Show("Inventory file corrupted or invalid.");
            }

        }
        public static int GetLowStockCount(int threshold = 5)
        {
            return InventoryItems
                .Where(i => (i.Quantity ?? 0) <= threshold)
                .Count();
        }

        public static void SaveToJson()
        {
            try
            {
                string json = JsonConvert.SerializeObject(InventoryItems, Formatting.Indented);
                File.WriteAllText(jsonFilePath, json);

                // 🔥 ADD THIS LINE
                UC_Home.Instance?.UpdateLowInventoryAlert();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}");
            }
        }
    }
}



