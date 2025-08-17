using Microsoft.EntityFrameworkCore;
using SSMS.API.Data.Entitities;
using SSMS.API.Data.Entitities.SmartHouse;
using SSMS.API.Data.Entitities.SmartJobs;

namespace SSMS.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Country>Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<EmployeeQualification> EmployeeQualifications { get; set; }
        public DbSet<EmployeeLanguage> EmployeeLanguages { get; set; }
        public DbSet<Customer> Customers { get; set; }

        //Attendance Portal


        //Digital Library


        //ECommerce


        //Employee Payroll


        //Smart Caregiver


        //Smart House
        public DbSet<Complain> Complains { get; set; }
        public DbSet<FurnishedItem> FurnishedItems { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<HouseAdminProfile> HouseAdminProfiles { get; set; }
        public DbSet<HouseImage> HouseImages { get; set; }
        public DbSet<HouseParking> HouseParkings { get; set; }
        public DbSet<HouseType> HouseTypes { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<OwnerProfile> OwnerProfiles { get; set; }
        public DbSet<RentList> RentLists { get; set; }
        public DbSet<SellList> SellLists { get; set; }
        public DbSet<Society> Societies { get; set; }
        public DbSet<TenantProfile> TenantProfiles { get; set; }


        //Smart Jobs
        public DbSet<CompanyProfile> CompanyProfiles { get; set; }
        public DbSet<CompanyReview> CompanyReviews { get; set; }
        public DbSet<CompanySize> CompanySizes { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Industry> Industries { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobAlert> JobAlerts { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<JobSeekerEducation> JobSeekerEducations { get; set; }
        public DbSet<JobSeekerExperience> JobSeekerExperiences { get; set; }
        public DbSet<JobSeekerProfile> JobSeekers { get; set; }
        public DbSet<PostJob> PostJobs { get; set; }
        public DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }


        //Seeding Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Super Admin" }, 
                new Role { Id = 2, Name = "Intern Developer" },
                new Role { Id = 3, Name = "Smart House Admin" },
                new Role { Id = 4, Name = "Smart House Owner" },
                new Role { Id = 5, Name = "Smart House Tenant" },
                new Role { Id = 6, Name = "Smart Jobs Admin" },
                new Role { Id = 7, Name = "Smart Jobs Company" },
                new Role { Id = 8, Name = "Smart Jobs Seeker" },
                new Role { Id = 9, Name = "Employee Payroll Admin" },
                new Role { Id = 10, Name = "Employee Payroll Employee" },
                new Role { Id = 11, Name = "Attendance Portal Admin" },
                new Role { Id = 12, Name = "Attendance Portal Staff" },
                new Role { Id = 13, Name = "Attendance Portal Student" },
                new Role { Id = 14, Name = "ECommerce Admin" },
                new Role { Id = 15, Name = "ECommerce Buyer" },
                new Role { Id = 16, Name = "Digital Library Admin" },
                new Role { Id = 17, Name = "Digital Library Student" },
                new Role { Id = 18, Name = "Smart Caregiver Admin" },
                new Role { Id = 19, Name = "Smart Caregiver Staff" },
                new Role { Id = 20, Name = "Smart Caregiver Patient" });
            
            modelBuilder.Entity<User>().HasData(new User { Id = 1, Name = "Anil", Email = "anil@gmail.com", Password = "123" });
            modelBuilder.Entity<UserRole>().HasData(new UserRole { Id = 1, UserId = 1, RoleId = 1 });
        }
    }
}
