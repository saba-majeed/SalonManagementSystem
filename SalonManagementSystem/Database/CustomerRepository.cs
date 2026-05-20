using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SalonManagementSystem.Models;

namespace SalonManagementSystem.Database
{
    /// <summary>
    /// Customer ke saare CRUD database operations
    /// </summary>
    public class CustomerRepository
    {
        /// <summary>
        /// Database se saare customers laata hai - naam ke order mein
        /// </summary>
        public List<Customer> GetAll()
        {
            var list = new List<Customer>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Customers ORDER BY FullName";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Customer
                        {
                            CustomerID = Convert.ToInt32(reader["CustomerID"]),
                            FullName = reader["FullName"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Email = reader["Email"].ToString(),
                            Address = reader["Address"].ToString(),
                            CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                        });
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Naya customer database mein add karta hai
        /// Return: true = success, false = error
        /// </summary>
        public bool Add(Customer c)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO Customers (FullName, Phone, Email, Address)
                                     VALUES (@name, @phone, @email, @address)";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", c.FullName);
                        cmd.Parameters.AddWithValue("@phone", c.Phone);
                        cmd.Parameters.AddWithValue("@email", c.Email);
                        cmd.Parameters.AddWithValue("@address", c.Address);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Existing customer ki info update karta hai
        /// </summary>
        public bool Update(Customer c)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE Customers
                                     SET FullName=@name, Phone=@phone,
                                         Email=@email, Address=@address
                                     WHERE CustomerID=@id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", c.FullName);
                        cmd.Parameters.AddWithValue("@phone", c.Phone);
                        cmd.Parameters.AddWithValue("@email", c.Email);
                        cmd.Parameters.AddWithValue("@address", c.Address);
                        cmd.Parameters.AddWithValue("@id", c.CustomerID);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Customer ko ID se delete karta hai
        /// </summary>
        public bool Delete(int customerID)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Customers WHERE CustomerID=@id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", customerID);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Name ya phone number se customer search karta hai
        /// </summary>
        public List<Customer> Search(string keyword)
        {
            var list = new List<Customer>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Customers WHERE FullName LIKE @kw OR Phone LIKE @kw";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    // % lagane se partial match bhi milta hai
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Customer
                            {
                                CustomerID = Convert.ToInt32(reader["CustomerID"]),
                                FullName = reader["FullName"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                Email = reader["Email"].ToString(),
                                Address = reader["Address"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}
