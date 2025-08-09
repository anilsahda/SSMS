using SSMS.API.Data.Entitities;
using SSMS.API.Data.Interfaces;

namespace SSMS.API.Data.Services
{
    public class UserRoleService : IUserRole
    {
        private readonly AppDbContext _context;
        public UserRoleService(AppDbContext context)
        {
            _context = context;
        }

        public bool AddUserRole(UserRole userRole)
        {
            _context.UserRoles.Add(userRole);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteUserRoleById(int id)
        {
            var userRole = _context.UserRoles.Find(id);
            _context.UserRoles.Remove(userRole);
            _context.SaveChanges();
            return true;
        }

        public UserRole GetUserRoleById(int id)
        {
            return _context.UserRoles.Find(id);
        }

        public List<UserRole> GetUserRoles()
        {
            return _context.UserRoles.ToList();
        }

        public bool UpdateUserRole(UserRole userRole)
        {
            _context.UserRoles.Update(userRole);
            _context.SaveChanges();
            return true;
        }
    }
}
