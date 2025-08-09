using SSMS.API.Data.Entitities;

namespace SSMS.API.Data.Interfaces
{
    public interface IRole
    {
        List<Role> GetRoles();
        Role GetRoleById(int id);
        bool UpdateRole(Role role);
        bool AddRole(Role role);
        bool DeleteRoleById(int id);
    }
}
