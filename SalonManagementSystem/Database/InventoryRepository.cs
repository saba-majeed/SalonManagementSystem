using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SalonManagementSystem.Models;

namespace SalonManagementSystem.Database
{
    /// <summary>
    /// Inventory (products/stock) ke CRUD operations
    /// </summary>
    public class InventoryRepository
    {
        /// <summary>
        /// Saare inventory items laata hai naam ke order mein
        /// </summary>
        public List<Inventory> GetAll()
        {
            var list = new List<Inventory>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Inventory ORDER BY ItemName";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Inventory
                        {
                            ItemID = Convert.ToInt32(reader["ItemID"]),
                            ItemName = reader["ItemName"].ToString(),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                            Supplier = reader["Supplier"].ToString(),
                            LastUpdated = Convert.ToDateTime(reader["LastUpdated"])
                        });
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Naya inventory item add karta hai
        /// </summary>
        public bool Add(Inventory item)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO Inventory (ItemName, Quantity, UnitPrice, Supplier)
                                     VALUES (@name, @qty, @price, @sup)";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", item.ItemName);
                        cmd.Parameters.AddWithValue("@qty", item.Quantity);
                        cmd.Parameters.AddWithValue("@price", item.UnitPrice);
                        cmd.Parameters.AddWithValue("@sup", item.Supplier);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Item update karta hai (stock, price etc.)
        /// </summary>
        public bool Update(Inventory item)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE Inventory
                                     SET ItemName=@name, Quantity=@qty,
                                         UnitPrice=@price, Supplier=@sup
                                     WHERE ItemID=@id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", item.ItemName);
                        cmd.Parameters.AddWithValue("@qty", item.Quantity);
                        cmd.Parameters.AddWithValue("@price", item.UnitPrice);
                        cmd.Parameters.AddWithValue("@sup", item.Supplier);
                        cmd.Parameters.AddWithValue("@id", item.ItemID);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Item delete karta hai ID se
        /// </summary>
        public bool Delete(int itemID)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Inventory WHERE ItemID=@id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", itemID);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }
    }
}