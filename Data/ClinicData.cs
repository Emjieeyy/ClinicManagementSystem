using ClinicManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;              // ✅ REQUIRED
using System.Text.Json;       // ✅ REQUIRED

namespace ClinicManagementSystem.Data
{
    public static class ClinicData
    {
        public static BindingList<StudentRecord> StudentRecords { get; private set; }
            = new BindingList<StudentRecord>();

        private static string filePath = "students.json";

        public static void LoadData()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var list = JsonSerializer.Deserialize<List<StudentRecord>>(json);

                if (list != null)
                {
                    StudentRecords.Clear();
                    foreach (var record in list)
                        StudentRecords.Add(record);
                }
            }
        }

        public static void SaveData()
        {
            try
            {
                // Convert BindingList to a regular List before serializing
                var listToSave = new List<StudentRecord>(StudentRecords);
                string json = JsonSerializer.Serialize(listToSave, new JsonSerializerOptions { WriteIndented = true });

                // Use a more reliable path for testing
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                // This will tell you if the 'Save' button is actually failing due to a file error
                System.Windows.Forms.MessageBox.Show("File Error: " + ex.Message);
            }
        }
    }
}
