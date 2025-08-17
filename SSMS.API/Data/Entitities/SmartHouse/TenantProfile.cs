namespace SSMS.API.Data.Entitities.SmartHouse
{
    public class TenantProfile
    {
        public int Id { get; set; }
        public string UserId { get; set; }              // Reference to Identity User
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int OccupationId { get; set; }          // Job/Business
        public int HouseId { get; set; }
        public int OwnerId { get; set; }
        public DateTime RentStartDate { get; set; }
        public DateTime? RentEndDate { get; set; }
        public string CurrentAddress { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}