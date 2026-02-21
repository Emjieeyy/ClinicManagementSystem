using ClinicManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq; // REQUIRED for filtering logic
using System.Text;

namespace ClinicManagementSystem.Data
{
    // Changed to 'public static' so you don't have to create an instance to use it
    public static class StudentDataService
    {
        public static List<StudentRecord> GetFilteredRecords(string searchTerm = "")
        {
            // 1. Refresh the main list from the JSON file
            ClinicData.LoadData();

            // 2. Start with only the logged-in user's records (Privacy Filter)
            var query = ClinicData.StudentRecords
                .Where(r => r.StudentID == SessionManager.CurrentID);

            // 3. If there is a search term, narrow it down
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                string lowerTerm = searchTerm.Trim().ToLower();
                query = query.Where(s =>
                    (s.Symptoms?.ToLower().Contains(lowerTerm) ?? false) ||
                    (s.Course?.ToLower().Contains(lowerTerm) ?? false) ||
                    (s.DateVisited.ToString().Contains(lowerTerm))
                );
            }

            // 4. Return the list sorted by most recent date so the newest visit is on top
            return query.OrderByDescending(r => r.DateVisited).ToList();
        }
    }
}