namespace SSMS.API.Data.Entitities.SSHouse
{
    public class FurnishedItem
    {
        public int Id { get; set; }
        public int HouseId { get; set; }                // FK → House
        public string ItemName { get; set; }            // Sofa, Bed, AC, Fridge
        public DateTime CreatedAt { get; set; }
    }

}