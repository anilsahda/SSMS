namespace SSMS.API.Data.Entitities.SSJobs
{
    public class Job
    {
        public int Id { get; set; }                     // Primary Key
        public int CompanyProfileId { get; set; }       // FK to CompanyProfile
        public string JobTitle { get; set; }            // like Software Developer
        public int JobCategoryId { get; set; }          // Job Category (e.g., Software Development, Banking, Healthcare, Marketing)
        public string Description { get; set; }         // Job description
        public string Requirements { get; set; }        // Skills / Requirements
        public string Location { get; set; }            // Job Location
        public int EmploymentTypeId { get; set; }      // Full-Time, Part-Time, Internship, Contract
        public string SalaryRange { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
