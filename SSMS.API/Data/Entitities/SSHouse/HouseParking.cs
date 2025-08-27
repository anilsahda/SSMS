namespace SSMS.API.Data.Entitities.SSHouse
{
    public class HouseParking
    {
        public int Id { get; set; }
        public int HouseId { get; set; }               // FK → House
        public string ParkingType { get; set; }        // Car, Bike, Both
    }

}