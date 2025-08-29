namespace SSMS.API.Data.Entitities.SSCaregiver
{
    public class SchedulesStatus
    {
        public int Id { get; set; } //(PK)
        public string Name { get; set; } //Scheduled, Completed, Cancelled, No-Show
    }
}