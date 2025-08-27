namespace SSMS.API.Data.Entitities
{
    public class Certifications
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string IssuedBy { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
