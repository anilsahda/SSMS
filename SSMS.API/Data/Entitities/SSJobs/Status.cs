namespace SSMS.API.Data.Entitities.SSJobs
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; } //Approved, Rejected, Pending, Resolved
        public string StatusCategory { get; set; } // Complain, Leave
    }
}
