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
}
