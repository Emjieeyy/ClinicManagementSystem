using ClinicManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicManagementSystem.Data
{
    public static class ClinicService
    {
        public static void AddOrUpdateConsultation(
        string studentNumber,
        string studentName,
        string course,
        string symptoms,
        string medicine,
        string role)
        {
            // 1. Force a fresh load of the JSON file so we have the latest list
            ClinicData.LoadData();

            // 2. Always create a BRAND NEW record for a new visit
            var newRecord = new StudentRecord
            {
                StudentID = studentNumber,
                StudentName = studentName,
                Course = course,
                Symptoms = symptoms,
                DateVisited = DateTime.Now // Automatically captures the visit time
            };

            // 3. Add medicine ONLY if the user is Staff
            if (role == "Staff")
            {
                newRecord.UpdateMedicine(medicine);
            }

            // 4. Add this new visit to the collection
            ClinicData.StudentRecords.Add(newRecord);

            // 5. Save the updated list back to the JSON file
            ClinicData.SaveData();
        }
    }
}