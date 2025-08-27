namespace SSMS.API.Data.Entitities.SSHouse
{
    public class HouseAdminProfile
    {
        public int Id { get; set; }                     // Primary Key
        public string UserId { get; set; }              // Reference to Identity User
    }
}