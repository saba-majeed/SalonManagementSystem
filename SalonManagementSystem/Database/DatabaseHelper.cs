using System;
using MySql.Data.MySqlClient;

namespace SalonManagementSystem.Database
{
    public class DatabaseHelper
    {
        // ⚠️ MySQL connection string - update password if changed
        private static string connectionString =
            "Server=localhost;Database=SalonManagementDB;Uid=root;Pwd=admin1234;";

        // Returns a new MySQL connection object
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Tests database connection - returns true if connected
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
