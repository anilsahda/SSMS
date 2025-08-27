namespace SSMS.API.Data.Entitities.SSHouse
{
    public class House
    {
        public int Id { get; set; }                          // Primary Key
        public int SocietyId { get; set; }                   // FK → Society
        public string HouseNumber { get; set; }              // Unique house/flat number
        public string Block { get; set; }                    // Block/Tower/Wing (if applicable)
        public string FloorNumber { get; set; }              // Floor number (for apartments)
        public string HouseTypeId { get; set; }              // 1BHK, 2BHK, Flat, Villa, Duplex, Studio, etc.
        public decimal AreaInSqFt { get; set; }              // Carpet area
        public int NumberOfBedrooms { get; set; }            // BHK (1, 2, 3…)
        public int NumberOfBathrooms { get; set; }
        public int NumberOfBalconies { get; set; }
        public int UserId { get; set; }                    // FK → Owner
        public string CurrentStatus { get; set; }            // Vacant, Rented, Occupied by Owner
        public string Description { get; set; }              // Additional details
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}