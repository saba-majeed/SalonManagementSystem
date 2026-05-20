using System;
using MySql.Data.MySqlClient;

namespace SalonManagementSystem.Database
{
    /// <summary>
    /// Database connection helper class
    /// Yahan se poori application MySQL se connect hoti hai
    /// </summary>
    public class DatabaseHelper
    {
        // ⚠️ IMPORTANT: Apna MySQL root password yahan likho
        private static string connectionString =
            "Server=localhost;Database=SalonManagementDB;Uid=root;Pwd=admin1234;";

        /// <summary>
        /// Naya MySQL connection object return karta hai
        /// </summary>
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Connection test karta hai - true aaye toh database connected hai
        /// </summary>
        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
