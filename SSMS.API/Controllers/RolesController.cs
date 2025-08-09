using Microsoft.AspNetCore.Mvc;
using SSMS.API.Data;
using SSMS.API.Data.Entitities;

namespace SSMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public RolesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetRoles()
        {
            return Ok(_context.Roles.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetRole(int id)
        {
            return Ok(_context.Roles.Find(id));
        }

        [HttpPut]
        public IActionResult UpdateRole(Role role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
            return Ok("Data updated successfully!");
        }

        [HttpPost]
        public IActionResult AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return Ok("Data added successfully!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoleById(int id)
        {
            var role = _context.Roles.Find(id);
            _context.Roles.Remove(role);
            _context.SaveChanges();
            return Ok("Data deleted successfully!");
        }
    }
}
