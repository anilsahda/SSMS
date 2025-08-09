using SSMS.Application.DTOs;

namespace SSMS.Application.Interfaces
{
    public interface IRole
    {
        List<RoleDto> GetRoles();
        RoleDto GetRoleById(int id);
        bool UpdateRole(RoleDto dto);
        bool AddRole(RoleDto dto);
        bool DeleteRoleById(int id);
    }
}
