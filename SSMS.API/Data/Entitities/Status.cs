namespace SSMS.API.Data.Entitities
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EntityId { get; set; }
    }
}

//Schedules(Scheduled, Completed, Cancelled, No-Show)
//CarePlanTasks(Pending, In Progress, Completed)
//Priority(High, Medium, Low)
//
