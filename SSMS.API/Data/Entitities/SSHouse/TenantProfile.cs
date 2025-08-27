namespace SSMS.API.Data.Entitities.SSHouse
{
    public class TenantProfile
    {
        public int Id { get; set; }
        public string UserId { get; set; }              // Reference to Identity User
        public int OccupationId { get; set; }          // Job/Business
        public int HouseId { get; set; }
        public int OwnerId { get; set; }
        public DateTime RentStartDate { get; set; }
        public DateTime? RentEndDate { get; set; }
        public string CurrentAddress { get; set; }
    }
}