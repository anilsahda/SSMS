using Microsoft.AspNetCore.Mvc;
using SSMS.API.Data;
using SSMS.API.Data.Entitities;
using SSMS.API.DTOs;

namespace SSMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public StudentsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = _context.Students.ToList();
            return Ok(students);
        }

        [HttpPost]
        public IActionResult AddStudent([FromBody] StudentDTO studentdto)
        {
            var student = new Student
            {
                FirstName = studentdto.FirstName,
                MiddleName = studentdto.MiddleName,
                LastName = studentdto.LastName,
                Address = studentdto.Address,
                Email = studentdto.Email,
                Mobile = studentdto.Mobile,
                CountryId = studentdto.CountryId,
                StateId = studentdto.StateId,
                DistrictId = studentdto.DistrictId,
                GenderId = studentdto.GenderId
            };

            _context.Students.Add(student);
            _context.SaveChanges();

            return Ok(student);
        }

        [HttpPut]
        public IActionResult UpdateStudent([FromBody] StudentDTO studentdto)
        {
            var student = new Student
            {
                Id = studentdto.Id,
                FirstName = studentdto.FirstName,
                MiddleName = studentdto.MiddleName,
                LastName = studentdto.LastName,
                Address = studentdto.Address,
                Email = studentdto.Email,
                Mobile = studentdto.Mobile,
                CountryId = studentdto.CountryId,
                StateId = studentdto.StateId,
                DistrictId = studentdto.DistrictId,
                GenderId = studentdto.GenderId
            };

            _context.SaveChanges();
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            _context.Students.Remove(_context.Students.Find(id));
            _context.SaveChanges();
            return Ok("Deleted successfully");
        }
    }
}
