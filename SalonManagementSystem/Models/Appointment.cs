using System;

namespace SalonManagementSystem.Models
{
    /// <summary>
    /// Appointment model - customer ki service booking
    /// </summary>
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int CustomerID { get; set; }
        public int StaffID { get; set; }
        public int ServiceID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; }  // Pending / Completed / Cancelled
        public string Notes { get; set; }

        // Ye fields database JOIN se aate hain - display ke liye
        public string CustomerName { get; set; }
        public string StaffName { get; set; }
        public string ServiceName { get; set; }
    }
}
