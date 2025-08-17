namespace SSMS.API.Data.Entitities.SmartHouse
{
    public class HouseAdminProfile
    {
        public int Id { get; set; }                     // Primary Key
        public string UserId { get; set; }              // Reference to Identity User
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Pincode { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}