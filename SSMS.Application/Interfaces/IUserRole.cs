using SSMS.Application.DTOs;

namespace SSMS.Application.Interfaces
{
    public interface IUserRole
    {
        List<UserRoleDto> GetUserRoles();
        UserRoleDto GetUserRoleById(int id);
        bool UpdateUserRole(UserRoleDto dto);
        bool AddUserRole(UserRoleDto dto);
        bool DeleteUserRoleById(int id);
    }
}
