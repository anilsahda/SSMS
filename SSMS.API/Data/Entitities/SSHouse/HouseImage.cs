namespace SSMS.API.Data.Entitities.SSHouse
{
    public class HouseImage
    {
        public int Id { get; set; }
        public int HouseId { get; set; }               // FK → House
        public string ImageUrl { get; set; }           // Path to image
        public string Caption { get; set; }            // Optional (e.g., "Living Room")
    }

}