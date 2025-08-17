namespace SSMS.API.Data.Entitities.SmartJobs
{
    public class CompanyProfile
    {
        public int Id { get; set; }                     // Primary Key
        public string UserId { get; set; }              // FK to Users (AspNetUsers/Employee)
        public string Address { get; set; }
        public string City { get; set; }
        public int? StateId { get; set; }               // FK to State
        public int? CountryId { get; set; }             // FK to Country
        public string Pincode { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }
        public string Website { get; set; }
        public string LogoUrl { get; set; }
        public string Detail { get; set; }
        public int? IndustryId { get; set; }            // FK to Industry
        public int? CompanySizeId { get; set; }         // FK to CompanySize
        public DateTime EstablishedDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsVerified { get; set; }
    }
}
