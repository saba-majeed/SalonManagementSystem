using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SalonManagementSystem.Models;

namespace SalonManagementSystem.Database
{
    /// <summary>
    /// Salon services ke CRUD operations (haircut, facial etc.)
    /// </summary>
    public class ServiceRepository
    {
        /// <summary>
        /// Saari services laata hai naam ke order mein
        /// </summary>
        public List<Service> GetAll()
        {
            var list = new List<Service>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Services ORDER BY ServiceName";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Service
                        {
                            ServiceID = Convert.ToInt32(reader["ServiceID"]),
                            ServiceName = reader["ServiceName"].ToString(),
                            Description = reader["Description"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"]),
                            DurationMinutes = Convert.ToInt32(reader["DurationMinutes"])
                        });
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Nayi service add karta hai
        /// </summary>
        public bool Add(Service s)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO Services (ServiceName, Description, Price, DurationMinutes)
                                     VALUES (@name, @desc, @price, @dur)";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", s.ServiceName);
                        cmd.Parameters.AddWithValue("@desc", s.Description);
                        cmd.Parameters.AddWithValue("@price", s.Price);
                        cmd.Parameters.AddWithValue("@dur", s.DurationMinutes);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Service update karta hai
        /// </summary>
        public bool Update(Service s)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE Services
                                     SET ServiceName=@name, Description=@desc,
                                         Price=@price, DurationMinutes=@dur
                                     WHERE ServiceID=@id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", s.ServiceName);
                        cmd.Parameters.AddWithValue("@desc", s.Description);
                        cmd.Parameters.AddWithValue("@price", s.Price);
                        cmd.Parameters.AddWithValue("@dur", s.DurationMinutes);
                        cmd.Parameters.AddWithValue("@id", s.ServiceID);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Service delete karta hai ID se
        /// </summary>
        public bool Delete(int serviceID)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Services WHERE ServiceID=@id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", serviceID);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }
    }
}
