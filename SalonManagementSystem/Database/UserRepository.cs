using System;
using MySql.Data.MySqlClient;
using SalonManagementSystem.Models;

namespace SalonManagementSystem.Database
{
    public class UserRepository
    {
        // Checks username & password in database
        // Returns User object if match found, null if not
        public User Login(string username, string password)
        {
            User user = null;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Parameterized query - prevents SQL injection
                    string query = "SELECT * FROM Users WHERE Username=@username AND Password=@password";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Row found = credentials correct
                            {
                                // Build user object from database row
                                user = new User
                                {
                                    UserID = Convert.ToInt32(reader["UserID"]),
                                    Username = reader["Username"].ToString(),
                                    Role = reader["Role"].ToString()
                                };
                            }
                        }
                    }
                } // Connection auto-closes here
            }
            catch (Exception ex)
            {
                throw new Exception("Login error: " + ex.Message);
            }

            return user; // null = login failed
        }
    }
}
