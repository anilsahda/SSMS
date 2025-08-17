namespace SSMS.API.Data.Entitities.SmartJobs
{
    public class JobSeekerExperience
    {
        public int Id { get; set; }
        public int JobSeekerProfileId { get; set; }    // FK to JobSeekerProfile
        public string CompanyName { get; set; }        // Past/Current company
        public string Position { get; set; }           // Job Title
        public DateTime StartDate { get; set; }        // Joining date
        public DateTime? EndDate { get; set; }         // Null if currently working
        public string Responsibilities { get; set; }   // Work responsibilities
        public decimal? Salary { get; set; }           // Salary (optional)
    }


}
