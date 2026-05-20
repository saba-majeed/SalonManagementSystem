using System;

namespace SalonManagementSystem.Models
{
    /// <summary>
    /// Staff model - salon employees ki info
    /// </summary>
    public class Staff
    {
        public int StaffID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Specialization { get; set; }  // e.g. "Hair Expert"
        public decimal Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public bool IsActive { get; set; }  // true = active employee
    }
}
