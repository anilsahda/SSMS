namespace SSMS.API.Data.Entitities.SSJobs
{
    public class SubscriptionPlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }          // Employers usually buy credits or subscriptions to post jobs.
        public int JobPostingLimit { get; set; }    // Example: Free Plan (1 job), Premium Plan (50 jobs).
    }
}
