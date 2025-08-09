using SSMS.API.Data.Entitities;

namespace SSMS.API.Data.Interfaces
{
    public interface IUser
    {
        List<User> GetUsers();
        User GetUserById(int id);
        bool UpdateUser(User user);
        bool AddUser(User user);
        bool DeleteUserById(int id);
    }
}
