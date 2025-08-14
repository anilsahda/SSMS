using Microsoft.AspNetCore.Mvc;
using SSMS.API.Data;
using SSMS.API.Data.Entitities;
using SSMS.API.DTOs;
using System.IO;

namespace SSMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public StudentsController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
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
                GenderId = studentdto.GenderId,
                Image = studentdto.Image
            };

            _context.Students.Add(student);
            _context.SaveChanges();

            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, [FromBody] StudentDTO studentdto)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound("Student not found");
            }

            student.FirstName = studentdto.FirstName;
            student.MiddleName = studentdto.MiddleName;
            student.LastName = studentdto.LastName;
            student.Address = studentdto.Address;
            student.Email = studentdto.Email;
            student.Mobile = studentdto.Mobile;
            student.CountryId = studentdto.CountryId;
            student.StateId = studentdto.StateId;
            student.DistrictId = studentdto.DistrictId;
            student.GenderId = studentdto.GenderId;
            student.Image = studentdto.Image;

            _context.SaveChanges();
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null) return NotFound();

            _context.Students.Remove(student);
            _context.SaveChanges();
            return Ok("Deleted successfully");
        }
    }
}
