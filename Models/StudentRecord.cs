using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Models
{
    public class StudentRecord
    {
        // Student Info
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string Course { get; set; }

        // Consultation Info
        public string Symptoms { get; set; }
        public string Medicine { get; set; }
        public DateTime DateVisited { get; set; }

        public StudentRecord()
        {
            DateVisited = DateTime.Now;

        }
    }
}


