using SSMS.API.Data.Entitities;
using SSMS.API.Data.Interfaces;

namespace SSMS.API.Data.Services
{
    public class RoleService : IRole
    {
        private readonly AppDbContext _context;
        public RoleService(AppDbContext context)
        {
            _context = context;
        }
        public bool AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteRoleById(int id)
        {
            var role = _context.Roles.Find(id);
            _context.Roles.Remove(role);
            _context.SaveChanges();
            return true;
        }

        public Role GetRoleById(int id)
        {
            return _context.Roles.Find(id);

        }

        public List<Role> GetRoles()
        {
            return _context.Roles.ToList();
        }

        public bool UpdateRole(Role role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
            return true;
        }
    }
}
