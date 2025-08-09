using Microsoft.AspNetCore.Mvc;
using SSMS.Application.DTOs;
using SSMS.Application.Interfaces;

namespace SSMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRolesController : ControllerBase
    {
        private readonly IUserRole _userRole;
        public UserRolesController(IUserRole userRole)
        {
            _userRole = userRole;
        }

        [HttpGet]
        public IActionResult GetUserRoles()
        {
            return Ok(_userRole.GetUserRoles());
        }

        [HttpGet("{id}")]
        public IActionResult GetUserRoleById(int id)
        {
            return Ok(_userRole.GetUserRoleById(id));
        }

        [HttpPut]
        public IActionResult UpdateUser(UserRoleDto dto)
        {
            var result = _userRole.UpdateUserRole(dto);
            return Ok("Data updated successfully!");
        }

        [HttpPost]
        public IActionResult AddUserRole(UserRoleDto dto)
        {
            var result = _userRole.AddUserRole(dto);
            return Ok("Data added successfully!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUserRoleById(int id)
        {
            var result = _userRole.DeleteUserRoleById(id);
            return Ok("Data deleted successfully!");
        }
    }
}