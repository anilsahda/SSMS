namespace SSMS.API.Data.Entitities.SSCaregiver
{
    public class PatientFamily
    {
        public int Id { get; set; }  //(PK) FamilyId
        public int PatientId { get; set; } //(FK → Patients)
        public int UserId { get; set; } //(FK → Users → (Family Member))
        public int RelationId { get; set; } // (Son, Daughter, Guardian, etc.)
    }
}
