using Microsoft.EntityFrameworkCore;
using SSMS.API.Data.Entitities;

namespace SSMS.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Super Admin" }, 
                new Role { Id = 2, Name = "Admin" }, 
                new Role { Id = 3, Name = "Interners" });
            
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Anil", Email = "anil@gmail.com", Password = "123" },
                new User { Id = 2, Name = "Amit", Email = "amit@gmail.com", Password = "123" },
                new User { Id = 3, Name = "Sumit", Email = "sumit@gmail.com", Password = "123" });
            
            modelBuilder.Entity<UserRole>().HasData(
                new UserRole { Id = 1, UserId = 1, RoleId = 1 },
                new UserRole { Id = 2, UserId = 2, RoleId = 2 },
                new UserRole { Id = 3, UserId = 3, RoleId = 3 });
        }
    }
}
