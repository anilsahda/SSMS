namespace SSMS.API.Data.Entitities.SmartHouse
{
    public class RentList
    {
        public int Id { get; set; }
        public int HouseId { get; set; }             // FK → House
        public int UserId { get; set; }             // FK → Owner

        public decimal RentAmount { get; set; }      // Monthly rent
        public decimal SecurityDeposit { get; set; } // Deposit amount
        public DateTime AvailableFrom { get; set; }  // Availability date
        public bool IsFurnished { get; set; }        // Furnished/Unfurnished
        public string Description { get; set; }      // Extra details

        public bool IsActive { get; set; } = true;   // Whether listing is active
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
