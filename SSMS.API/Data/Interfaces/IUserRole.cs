using SSMS.API.Data.Entitities;

namespace SSMS.API.Data.Interfaces
{
    public interface IUserRole
    {
        List<UserRole> GetUserRoles();
        UserRole GetUserRoleById(int id);
        bool UpdateUserRole(UserRole userRole);
        bool AddUserRole(UserRole userRole);
        bool DeleteUserRoleById(int id);
    }
}
