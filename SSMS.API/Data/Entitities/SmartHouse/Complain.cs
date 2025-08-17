namespace SSMS.API.Data.Entitities.SmartHouse
{
    public class Complain
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Reply { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
