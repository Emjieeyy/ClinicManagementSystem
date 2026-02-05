namespace ClinicManagementSystem.Models
{
    public class AuditLog
    {
        public string Timestamp { get; set; }
        public string Email { get; set; }
        public string Activity { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        // The problematic operator was here — I've removed it!
    }
}