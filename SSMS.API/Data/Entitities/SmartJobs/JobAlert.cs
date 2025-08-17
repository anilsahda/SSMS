namespace SSMS.API.Data.Entitities.SmartJobs
{
    public class JobAlert
    {
        public int Id { get; set; }
        public int JobSeekerProfileId { get; set; }     //  Notify job seekers when new jobs matching skills are posted.
        public string Criteria { get; set; }       // e.g., "C# Developer in Bangalore"
        public DateTime CreatedAt { get; set; }
    }
}
