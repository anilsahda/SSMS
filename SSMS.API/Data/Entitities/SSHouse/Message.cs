namespace SSMS.API.Data.Entitities.SSHouse
{
    public class Message
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
