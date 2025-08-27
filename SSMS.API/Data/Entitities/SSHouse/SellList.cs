namespace SSMS.API.Data.Entitities.SSHouse
{
    public class SellList
    {
        public int Id { get; set; }
        public int HouseId { get; set; }             // FK → House
        public int UserId { get; set; }             // FK → Owner

        public decimal SellingPrice { get; set; }    // Expected price
        public DateTime AvailableFrom { get; set; }
        public bool IsNegotiable { get; set; }       // Price negotiable or not
        public string Description { get; set; }

        public bool IsActive { get; set; } = true;   // Whether listing is active
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
