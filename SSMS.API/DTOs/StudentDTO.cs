namespace SSMS.API.DTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int DistrictId { get; set; }
        public int GenderId { get; set; }
    }
}