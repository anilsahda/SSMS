namespace SSMS.API.Data.Entitities.SSCaregiver
{
    public class CaregiverProfile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime HireDate { get; set; }
        public int SpecializationId { get; set; } // Nurse, Physiotherapist, Attendant
        public int ExperienceYears { get; set; }
        public int ShiftTypeId { get; set; }
        public int CaregiverStatusId { get; set; }
    }

    public class CaregiverAdminProfile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }

    public class CarePlans
    {
        public int Id { get; set; } //(PK)
        public int PatientId { get; set; } //(FK → Patients)
        public int CreatedBy { get; set; } // (FK → Users)
        public string CarePlan { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CarePlansId { get; set; } // Active, Completed, Cancelled
        public string Notes { get; set; }
    }


}
