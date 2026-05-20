using System;

namespace SalonManagementSystem.Models
{
    /// <summary>
    /// User model - login aur role management ke liye
    /// </summary>
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }      // "Admin" ya "Staff"
        public DateTime CreatedAt { get; set; }
    }
}
