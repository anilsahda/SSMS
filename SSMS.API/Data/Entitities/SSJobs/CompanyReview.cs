namespace SSMS.API.Data.Entitities.SSJobs
{
    public class CompanyReview
    {
        public int Id { get; set; }
        public int CompanyProfileId { get; set; }
        public int JobSeekerProfileId { get; set; }
        public int Rating { get; set; }           // Job seekers can rate/review companies 1–5 stars
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
