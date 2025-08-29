namespace SSMS.API.Data.Entitities.SSCaregiver
{
    public class CarePlans
    {
        public int Id { get; set; } //(PK)
        public int PatientId { get; set; } //(FK → Patients)
        public int CreatedBy { get; set; } // (FK → Users)
        public string CarePlan { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CarePlansStatusId { get; set; } // Active, Completed, Cancelled
        public string Notes { get; set; }
    }
}
