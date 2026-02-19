namespace ClinicManagementSystem.Models
{
    public class StudentRecord
    {
        public string StudentID { get; set; } = string.Empty;
        public string StudentName { get; set; } = string.Empty;
        public string Course { get; set; } = string.Empty;
        public string Symptoms { get; set; } = string.Empty;

        public string Medicine { get; set; } = string.Empty;

        // Add this missing property
        public DateTime DateVisited { get; set; }

        // Add this missing method
        public void UpdateMedicine(string medicine)
        {
            // Logic for what happens when medicine is updated
            // For example, if you have a Medicine property:
            // this.Medicine = medicine;
        }
    }
}