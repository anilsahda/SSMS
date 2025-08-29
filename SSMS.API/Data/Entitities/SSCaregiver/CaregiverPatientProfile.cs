namespace SSMS.API.Data.Entitities.SSCaregiver
{
    public class CaregiverPatientProfile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string MedicalRecordNumber { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string PrimaryDoctorId { get; set; }
        public int BloodGroupId { get; set; }
        public string Allergies { get; set; }
        public string ChronicConditions { get; set; }
        public string Notes { get; set; }
    }
}
