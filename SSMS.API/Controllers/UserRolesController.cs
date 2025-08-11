using Microsoft.AspNetCore.Mvc;
using SSMS.API.Data.Entitities;
using SSMS.API.Data;

namespace SSMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRolesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public UserRolesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetUserRole()
        {
            return Ok(_context.UserRoles.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetUserRole(int id)
        {
            return Ok(_context.UserRoles.Find(id));
        }

        [HttpPut]
        public IActionResult UpdateUserRole(UserRole userRole)
        {
            _context.UserRoles.Update(userRole);
            _context.SaveChanges();
            return Ok("Data updated successfully!");
        }

        [HttpPost]
        public IActionResult AddUserRole(UserRole userRole)
        {
            _context.UserRoles.Add(userRole);
            _context.SaveChanges();
            return Ok("Data added successfully!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUserRoleById(int id)
        {
            var userRole = _context.UserRoles.Find(id);
            _context.UserRoles.Remove(userRole);
            _context.SaveChanges();
            return Ok("Data deleted successfully!");
        }

    }
}
