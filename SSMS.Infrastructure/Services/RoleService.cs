using SSMS.Application.DTOs;
using SSMS.Application.Interfaces;
using SSMS.Domain.Entities;

namespace SSMS.Infrastructure.Services
{
    public class RoleService : IRole
    {
        private readonly AppDbContext _context;
        public RoleService(AppDbContext context)
        {
            _context = context;
        }

        public List<RoleDto> GetRoles()
        {
            return _context.Roles.Select(u => new RoleDto
            {
                Id = u.Id,
                Name = u.Name
            }).ToList();
        }

        public RoleDto GetRoleById(int id)
        {
            var role = _context.Roles.Find(id);
            return new RoleDto
            {
                Id = role.Id,
                Name = role.Name
            };
        }

        public bool AddRole(RoleDto dto)
        {
            var role = new Role
            {
                Name = dto.Name
            };
            _context.Roles.Add(role);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateRole(RoleDto dto)
        {
            var role = new Role
            {
                Id = dto.Id,
                Name = dto.Name
            };
            _context.Roles.Update(role);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteRoleById(int id)
        {
            var role = _context.Roles.Find(id);
            _context.Roles.Add(role);
            _context.SaveChanges();
            return true;
        }
    }
}