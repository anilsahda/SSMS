using Microsoft.AspNetCore.Mvc;
using SSMS.API.Data.Entitities;
using SSMS.API.Data;

namespace SSMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;
        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetUser()
        {
            return Ok(_context.Users.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            return Ok(_context.Users.Find(id));
        }

        [HttpPut]
        public IActionResult UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return Ok("Data updated successfully!");
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok("Data added successfully!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUserById(int id)
        {
            var user = _context.Users.Find(id);
            _context.Users.Remove(user);
            _context.SaveChanges();
            return Ok("Data deleted successfully!");
        }
    }
}
