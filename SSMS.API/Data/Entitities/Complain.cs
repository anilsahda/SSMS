namespace SSMS.API.Data.Entitities
{
    public class Complain
    {
        public int Id { get; set; }
        public int ComplainBy { get; set; }
        public int ComplainTo { get; set; }
        public string Subject { get; set; }
        public string Details { get; set; }
        public string Reply { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}