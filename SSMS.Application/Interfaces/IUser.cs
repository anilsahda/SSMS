using SSMS.Application.DTOs;

namespace SSMS.Application.Interfaces
{
    public interface IUser
    {
        Task<IEnumerable<UserDto>> GetAllAsync();
        Task<UserDto?> GetByIdAsync(int id);
        Task CreateAsync(UserDto dto);
    }
}
