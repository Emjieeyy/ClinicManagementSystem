using ClinicManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq; // Added this for .FirstOrDefault()
using System.Text;

namespace ClinicManagementSystem.Data
{
    // Removed the redundant outer class
    public static class ClinicService
    {
      public static void AddOrUpdateConsultation(
      string studentNumber,
      string studentName,
      string course,
      string symptoms,
      string medicine,
      string role) // Removed DateTime parameter
        {
            var record = ClinicData.StudentRecords
                .FirstOrDefault(r => r.StudentID == studentNumber);

            // Capture the running time right now
            DateTime currentTime = DateTime.Now;

            if (record == null)
            {
                record = new StudentRecord
                {
                    StudentID = studentNumber,
                    StudentName = studentName,
                    Course = course,
                    Symptoms = symptoms,
                    DateVisited = currentTime // Uses system time
                };

                if (role == "Staff")
                    record.UpdateMedicine(medicine);

                ClinicData.StudentRecords.Add(record);
            }
            else
            {
                record.Symptoms = symptoms;
                record.DateVisited = currentTime; // Updates to latest visit time

                if (role == "Staff")
                {
                    record.UpdateMedicine(medicine);
                    // ... (rest of your existing logic)
                }
            }

            ClinicData.SaveData();
        }
    }
}