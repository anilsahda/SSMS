namespace SSMS.API.Data.Entitities.DigitalLibrary
{
    public class LibrariandProfile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BranchId { get; set; }
        public int GenderId { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string Image { get; set; }
    }
}
