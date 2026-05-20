using System;

namespace SalonManagementSystem.Models
{
    /// <summary>
    /// Inventory model - salon products aur unka stock
    /// </summary>
    public class Inventory
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }     // stock kitna hai
        public decimal UnitPrice { get; set; }
        public string Supplier { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
