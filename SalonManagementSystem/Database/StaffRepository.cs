using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SalonManagementSystem.Models;

namespace SalonManagementSystem.Database
{
    public class StaffRepository
    {
        // Returns only active staff members (IsActive = 1)
        public List<Staff> GetAll()
        {
            var list = new List<Staff>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Staff WHERE IsActive=1 ORDER BY FullName";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Staff
                        {
                            StaffID = Convert.ToInt32(reader["StaffID"]),
                            FullName = reader["FullName"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Specialization = reader["Specialization"].ToString(),
                            Salary = Convert.ToDecimal(reader["Salary"]),
                            JoiningDate = Convert.ToDateTime(reader["JoiningDate"]),
                            IsActive = Convert.ToBoolean(reader["IsActive"])
                        });
                    }
                }
            }
            return list;
        }

        // Adds a new staff member to database
        public bool Add(Staff s)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO Staff (FullName, Phone, Specialization, Salary, JoiningDate)
                                     VALUES (@name, @phone, @spec, @salary, @date)";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", s.FullName);
                        cmd.Parameters.AddWithValue("@phone", s.Phone);
                        cmd.Parameters.AddWithValue("@spec", s.Specialization);
                        cmd.Parameters.AddWithValue("@salary", s.Salary);
                        cmd.Parameters.AddWithValue("@date", s.JoiningDate);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }

        // Updates existing staff member info
        public bool Update(Staff s)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE Staff
                                     SET FullName=@name, Phone=@phone,
                                         Specialization=@spec, Salary=@salary
                                     WHERE StaffID=@id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", s.FullName);
                        cmd.Parameters.AddWithValue("@phone", s.Phone);
                        cmd.Parameters.AddWithValue("@spec", s.Specialization);
                        cmd.Parameters.AddWithValue("@salary", s.Salary);
                        cmd.Parameters.AddWithValue("@id", s.StaffID);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }

        // Soft delete - sets IsActive=0 instead of removing record
        // Keeps data safe for old appointment history
        public bool Delete(int staffID)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Staff SET IsActive=0 WHERE StaffID=@id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", staffID);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }
    }
}
