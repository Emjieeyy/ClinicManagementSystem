using ClinicManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Windows.Forms; // Added for MessageBox

namespace ClinicManagementSystem.Data
{
    public static class ClinicData
    {
        public static BindingList<StudentRecord> StudentRecords { get; private set; } = new BindingList<StudentRecord>();
        private static string filePath = "students.json";

        public static void LoadData()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    if (string.IsNullOrWhiteSpace(json)) return; // Don't parse empty files

                    var list = JsonSerializer.Deserialize<List<StudentRecord>>(json);

                    if (list != null)
                    {
                        StudentRecords.Clear();
                        foreach (var record in list)
                        {
                            StudentRecords.Add(record);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        public static void SaveData()
        {
            try
            {
                var listToSave = new List<StudentRecord>(StudentRecords);
                string json = JsonSerializer.Serialize(listToSave, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("File Error: " + ex.Message);
            }
        }
    }
}