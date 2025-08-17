namespace SSMS.API.Data.Entitities.SmartHouse
{
    public class OwnerProfile
    {
        public int Id { get; set; }
        public string UserId { get; set; }              // Reference to Identity User
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TotalMember { get; set; }
        public int SocietyId { get; set; }              // Reference to Society
        public int HouseId { get; set; }                // Reference to House
        public string PermanentAddress { get; set; }
        public string Image { get; set; }
        public DateTime OwnershipStartDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}