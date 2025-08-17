namespace SSMS.API.Data.Entitities.SmartJobs
{
    public class JobSeekerProfile
    {
        public int Id { get; set; }         // Primary Key (unique identifier for each job seeker profile)
        public string UserId { get; set; }  // Foreign key reference to the User for login & authentication)
        public string Gender { get; set; }  // Gender of the job seeker (Male, Female, Other)
        public DateTime DateOfBirth { get; set; }// Date of birth of the job seeker (used for age calculation and eligibility checks)
        public string Mobile { get; set; }     // Contact mobile number of the job seeker
        public string Email { get; set; }     // Email address of the job seeker (used for communication and login recovery)
        public string Address { get; set; }   // Residential address (full address for job seeker)
        public string City { get; set; }      // City where the job seeker resides (useful for location-based job searches)
        public string State { get; set; }     // State/Province of the job seeker
        public string Country { get; set; }   // Country of the job seeker
        public string Pincode { get; set; }   // Postal/Zip code for job seeker’s location (helps in regional job filtering)
        public string Detail { get; set; }    // Short bio/profile summary (e.g., "I am a .NET developer with 3 years of experience")
        public string? ResumeUrl { get; set; } // File path or URL of the uploaded resume (PDF/DOC format)
        public string? ImageUrl { get; set; }  // File path or URL of the job seeker’s profile picture
        public DateTime CreatedAt { get; set; }  // Timestamp when the profile was created (auto-generated)
        public DateTime UpdatedAt { get; set; }  // Timestamp when the profile was last updated (useful for tracking changes)
        public bool IsVerified { get; set; }    // Profile has been verified by the admin (helps employers trust authenticity)?
    }
}
