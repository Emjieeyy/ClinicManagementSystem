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
        // In-memory BindingList for data binding (keeps UI updated)
        public static BindingList<InventoryItems> InventoryItems { get; private set; } = new BindingList<InventoryItems>();

        // Load JSON file into InventoryItems list
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

        // Save current InventoryItems list to JSON file
        public static void SaveToJson()
        {
            try
            {
                // Use the InventoryItems property defined at the top of your class
                string json = JsonConvert.SerializeObject(InventoryItems, Formatting.Indented);
                File.WriteAllText(jsonFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}");
            }
        }
    }
}
