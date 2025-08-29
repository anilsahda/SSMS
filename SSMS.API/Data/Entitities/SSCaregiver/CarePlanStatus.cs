namespace SSMS.API.Data.Entitities.SSCaregiver
{
    public class CarePlanStatus
    {
        public int Id { get; set; } //(PK)
        public string Name { get; set; } // Pending, In Progress, Completed
    }
}