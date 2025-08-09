using Microsoft.AspNetCore.Mvc;
using SSMS.API.Data.Entitities;
using SSMS.API.Data.Interfaces;

namespace SSMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRole _role;
        public RolesController(IRole role)
        {
            _role = role;
        }

        [HttpGet]
        public IActionResult GetRoles()
        {
            return Ok(_role.GetRoles());
        }

        [HttpGet("{id}")]
        public IActionResult GetRole(int id)
        {
            return Ok(_role.GetRoleById(id));
        }

        [HttpPut]
        public IActionResult UpdateRole(Role role)
        {
            var result = _role.UpdateRole(role);
            return Ok("Data updated successfully!");
        }

        [HttpPost]
        public IActionResult AddRole(Role role)
        {
            var result = _role.AddRole(role);
            return Ok("Data added successfully!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoleById(int id)
        {
            var result = _role.DeleteRoleById(id);
            return Ok("Data deleted successfully!");
        }
    }
}
