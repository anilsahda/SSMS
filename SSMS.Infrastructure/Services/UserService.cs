using SSMS.Application.DTOs;
using SSMS.Application.Interfaces;
using SSMS.Domain.Entities;

namespace SSMS.Infrastructure.Services
{
    public class UserService : IUser
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public List<UserDto> GetUsers()
        {
            return _context.Users.Select(u => new UserDto
            {
                Id = u.Id,
                Name = u.Name,
                Email = u.Email
            }).ToList();
        }

        public UserDto GetUserById(int id)
        {
            var user = _context.Users.Find(id);
            return new UserDto { Id = user.Id, Name = user.Name, Email = user.Email };
        }

        public bool AddUser(UserDto dto)
        {
            _context.Users.Add(new User { Name = dto.Name, Email = dto.Email, Password = dto.Password });
            _context.SaveChanges();
            return true;
        }

        public bool UpdateUser(UserDto dto)
        {
            _context.Users.Update(new User {Id=dto.Id,Name=dto.Name, Email=dto.Email, Password=dto.Password});
            _context.SaveChanges();
            return true;
        }

        public bool DeleteUserById(int id)
        {
            var user = _context.Users.Find(id);
            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }
    }
}