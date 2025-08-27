namespace SSMS.API.Data.Entitities.SSJobs
{
    public class CompanyProfile
    {
        public int Id { get; set; }                     // Primary Key
        public string UserId { get; set; }              // FK to Users (AspNetUsers/Employee)
        public string Website { get; set; }
        public string LogoUrl { get; set; }
        public int? IndustryId { get; set; }            // FK to Industry
        public int? CompanySizeId { get; set; }         // FK to CompanySize
    }
}
