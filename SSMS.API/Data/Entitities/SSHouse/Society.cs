namespace SSMS.API.Data.Entitities.SSHouse
{
    public class Society
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfHouse { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int DistrictId { get; set; }
        public string Pincode { get; set; }
        public string Image { get; set; }
    }
}
