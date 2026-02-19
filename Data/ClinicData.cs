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
                var listToSave = new List<StudentRecord>(StudentRecords);
                string json = JsonSerializer.Serialize(listToSave, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("File Error: " + ex.Message);
            }
        }


        public static string GetNextID()
        {
            int maxId = 1000;
            if (StudentRecords.Any())
            {
                int maxClinic = StudentRecords.Max(r => int.TryParse(r.StudentID, out int id) ? id : 0);
                if (maxClinic > maxId) maxId = maxClinic;
            }
            return (maxId + 1).ToString();
        }
    }
}