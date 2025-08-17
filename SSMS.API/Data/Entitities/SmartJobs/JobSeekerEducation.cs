namespace SSMS.API.Data.Entitities.SmartJobs
{
    public class JobSeekerEducation
    {
        public int Id { get; set; }
        public int JobSeekerProfileId { get; set; }    // FK to JobSeekerProfile
        public string Degree { get; set; }             // B.Tech, MBA, MSc
        public string Specialization { get; set; }     // Computer Science, Marketing, etc.
        public string University { get; set; }         // College/University Name
        public string PassYear { get; set; }           // Graduation Year
        public decimal? Percentage { get; set; }       // CGPA/Percentage (optional)
    }


}
