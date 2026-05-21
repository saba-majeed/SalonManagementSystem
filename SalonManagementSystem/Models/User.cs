using System;

namespace SalonManagementSystem.Models
{   
      // User Model - Stores logged in user's information
     // This model is used to carry user data between database and forms
  
    public class User
    {
        public int UserID { get; set; }  // Primary key
        public string Username { get; set; }  // Login username
        public string Password { get; set; }  // Login password
        public string Role { get; set; }  // Admin / Staff / Customer
        public DateTime CreatedAt { get; set; }  // Account creation date
    }
}
