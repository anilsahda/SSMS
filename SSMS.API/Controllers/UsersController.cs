using Microsoft.AspNetCore.Mvc;
using SSMS.Application.DTOs;
using SSMS.Application.Interfaces;

namespace SSMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUser _user;
        public UsersController(IUser user)
        {
            _user = user;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_user.GetUsers());
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            return Ok(_user.GetUserById(id));
        }

        [HttpPut]
        public IActionResult UpdateUser(UserDto dto)
        {
            var result = _user.UpdateUser(dto);
            return Ok("Data updated successfully!");
        }

        [HttpPost]
        public IActionResult AddUser(UserDto dto)
        {
            var result = _user.AddUser(dto);
            return Ok("Data added successfully!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUserById(int id)
        {
            var result = _user.DeleteUserById(id);
            return Ok("Data deleted successfully!");
        }
    }
}