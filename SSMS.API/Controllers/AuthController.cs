using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using SSMS.API.Data;
using SSMS.API.DTOs;

namespace SSMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDTO request)
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == request.Email && x.Password == request.Password);
            if (user == null)
            {
                return Ok(new { statusCode = "404" });
            }

            var userRole = _context.UserRoles.FirstOrDefault(x => x.UserId == user.Id);
            if (userRole == null)
            {
                return Ok(new { statusCode = "403" });
            }

            var role = _context.Roles.Find(userRole.RoleId);
            var token = GenerateJwtToken(user.Email, user.Name, role.Name);

            return Ok(new { token = token, role = role.Name, statusCode = "200", userName = user.Name });
        }

        private string GenerateJwtToken(string email, string name, string role)
        {
            if (string.IsNullOrEmpty(role))
            {
                role = "Admin";
            }
            var claims = new[]
            {
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Name, name),
                new Claim(ClaimTypes.Role, role)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ThisIsYourSuperSecretKeyForJwtToken123!"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "SSAppIssuer",
                audience: "SSAppAudience",
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
