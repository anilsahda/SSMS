namespace SSMS.API.Data.Entitities.SSJobs
{
    public class JobApplication
    {
        public int Id { get; set; }                     // Primary Key
        public int JobId { get; set; }                  // FK to Job
        public int JobSeekerProfileId { get; set; }     // FK to JobSeekerProfile
        public DateTime ApplicationDate { get; set; }   // Applied on
        public string Status { get; set; }              // Pending, Shortlisted, Rejected, Hired
    }


}
