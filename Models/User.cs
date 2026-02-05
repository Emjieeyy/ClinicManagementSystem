using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Models
{
    public class User
    {
        // These match the columns in your DataGridView
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
    }
}
