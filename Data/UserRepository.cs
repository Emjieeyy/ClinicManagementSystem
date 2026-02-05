using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ClinicManagementSystem.Models;

namespace ClinicManagementSystem.Data
{
    public class UserRepository
    {
        private string filePath = "users.json";

        public List<User> LoadUsers()
        {
            // 1. Check if the file exists OR if it is empty
            if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
            {
                // 2. Create the Default Admin automatically
                var defaultAdmin = new List<User>
                {
                    new User
                    {
                        UserID = "1001",
                        Name = "System Admin",
                        Role = "Admin",
                        Email = "admin@clinic.com",
                        Password = "admin", // Add this line
                        Status = "Offline"
                    }
                };

                // 3. Save this to the file so it persists
                SaveUsers(defaultAdmin);
                return defaultAdmin;
            }

            // 4. If file exists and has data, load it normally
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        public void SaveUsers(List<User> users)
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    } 
}