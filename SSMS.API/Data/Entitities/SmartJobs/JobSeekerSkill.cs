namespace SSMS.API.Data.Entitities.SmartJobs
{
    public class JobSeekerSkill
    {
        public int Id { get; set; }
        public int JobSeekerProfileId { get; set; }    // FK to JobSeekerProfile
        public string SkillName { get; set; }          // Example: "C#", "SQL", "React"
        public string Proficiency { get; set; }        // Beginner, Intermediate, Expert

    }


}
