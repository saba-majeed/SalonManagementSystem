using System;
using MySql.Data.MySqlClient;
using SalonManagementSystem.Models;

namespace SalonManagementSystem.Database
{
    /// <summary>
    /// User ke database operations
    /// Sirf login check karna abhi ke liye
    /// </summary>
    public class UserRepository
    {
        /// <summary>
        /// Username aur password match karta hai database se
        /// Return: User object (match hua) ya null (wrong credentials)
        /// </summary>
        public User Login(string username, string password)
        {
            User user = null;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Parameterized query - SQL injection se bachata hai
                    string query = "SELECT * FROM Users WHERE Username=@username AND Password=@password";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Credentials match - user object banao
                                user = new User
                                {
                                    UserID = Convert.ToInt32(reader["UserID"]),
                                    Username = reader["Username"].ToString(),
                                    Role = reader["Role"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Login error: " + ex.Message);
            }

            return user; // null = login fail
        }
    }
}
