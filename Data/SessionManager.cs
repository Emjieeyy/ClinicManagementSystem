using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Data
{
    internal class SessionManager
    {
        public static string CurrentID { get; set; }
        public static string CurrentName { get; set; }
        public static string Role { get; set; } // "Student" or "Staff"
    }
}
