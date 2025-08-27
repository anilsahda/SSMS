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

    public class PatientFamily
    {
        public int Id { get; set; }  //(PK) FamilyId
        public int PatientId { get; set; } //(FK → Patients)
        public int UserId { get; set; } //(FK → Users → (Family Member))
        public int RelationId { get; set; } // (Son, Daughter, Guardian, etc.)
    }

    public class Relation
    {
        public int Id { get; set; }
        public int Name { get; set; } // // (Son, Daughter, Guardian, etc.)
    }
}
