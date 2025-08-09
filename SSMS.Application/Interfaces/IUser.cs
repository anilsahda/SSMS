using SSMS.Application.DTOs;

namespace SSMS.Application.Interfaces
{
    public interface IUser
    {
        List<UserDto> GetUsers();
        UserDto GetUserById(int id);
        bool UpdateUser(UserDto dto);
        bool AddUser(UserDto dto);
        bool DeleteUserById(int id);
    }
}
