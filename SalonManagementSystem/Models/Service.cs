namespace SalonManagementSystem.Models
{
    /// <summary>
    /// Service model - salon ki services (haircut, facial etc.)
    /// </summary>
    public class Service
    {
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int DurationMinutes { get; set; }  // kitne minute lagenge
    }
}
