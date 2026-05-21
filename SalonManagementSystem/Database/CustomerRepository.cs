using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SalonManagementSystem.Models;

namespace SalonManagementSystem.Database
{
    public class CustomerRepository
    {
        // Returns all customers ordered by name
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

        // Adds a new customer to database
        // Returns true = success, false = error
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

        // Updates existing customer info
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

        // Deletes a customer by ID
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

        // Searches customers by name or phone number
        // % allows partial match e.g. "ali" finds "Ali Ahmed"
        public List<Customer> Search(string keyword)
        {
            var list = new List<Customer>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Customers WHERE FullName LIKE @kw OR Phone LIKE @kw";

                using (var cmd = new MySqlCommand(query, conn))
                {
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
