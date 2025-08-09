using SSMS.Application.DTOs;
using SSMS.Application.Interfaces;
using SSMS.Domain.Entities;

namespace SSMS.Infrastructure.Services
{
    public class UserRoleService : IUserRole
    {
        private readonly AppDbContext _context;
        public UserRoleService(AppDbContext context)
        {
            _context = context;
        }

        public List<UserRoleDto> GetUserRoles()
        {
            return _context.UserRoles.Select(u => new UserRoleDto
            {
                Id = u.Id,
                UserId = u.UserId,
                RoleId = u.RoleId
            }).ToList();
        }

        public UserRoleDto GetUserRoleById(int id)
        {
            var userrole = _context.UserRoles.Find(id);
            return new UserRoleDto
            {
                Id = userrole.Id,
                UserId = userrole.UserId
            };
        }

        public bool AddUserRole(UserRoleDto dto)
        {
            var userrole = new UserRole
            {
                UserId = dto.UserId,
                RoleId = dto.RoleId
            };
            _context.UserRoles.Add(userrole);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateUserRole(UserRoleDto dto)
        {
            var userrole = new UserRole
            {
                UserId = dto.UserId,
                RoleId = dto.RoleId
            };
            _context.UserRoles.Update(userrole);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteUserRoleById(int id)
        {
            var userrole = _context.UserRoles.Find(id);
            _context.UserRoles.Update(userrole);
            _context.SaveChanges();
            return true;
        }
    }
}