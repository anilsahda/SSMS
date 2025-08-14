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

        [HttpPut]
        public IActionResult UpdateStudent([FromBody] StudentDTO studentdto)
        {
            var student = _context.Students.Find(studentdto.Id);
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

        [HttpPost("AddImageUpload")]
        public async Task<IActionResult> AddStudent([FromForm] StudentFormDTO studentDto)
        {
            var student = new Student
            {
                FirstName = studentDto.FirstName,
                MiddleName = studentDto.MiddleName,
                LastName = studentDto.LastName,
                Address = studentDto.Address,
                Email = studentDto.Email,
                Mobile = studentDto.Mobile,
                CountryId = studentDto.CountryId,
                StateId = studentDto.StateId,
                DistrictId = studentDto.DistrictId,
                GenderId = studentDto.GenderId
            };

            if (studentDto.Image != null)
            {
                var fileName = $"{Guid.NewGuid()}{Path.GetExtension(studentDto.Image.FileName)}";
                var path = Path.Combine(_env.WebRootPath, "Uploads", fileName);
                using var stream = new FileStream(path, FileMode.Create);
                await studentDto.Image.CopyToAsync(stream);
                student.Image = fileName;
            }

            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return Ok(student);
        }

        [HttpPut("UpdateImageUpload")]
        public async Task<IActionResult> UpdateStudent([FromForm] StudentFormDTO studentDto)
        {
            var student = _context.Students.Find(studentDto.Id);
            if (student == null) return NotFound("Student not found");

            student.FirstName = studentDto.FirstName;
            student.MiddleName = studentDto.MiddleName;
            student.LastName = studentDto.LastName;
            student.Address = studentDto.Address;
            student.Email = studentDto.Email;
            student.Mobile = studentDto.Mobile;
            student.CountryId = studentDto.CountryId;
            student.StateId = studentDto.StateId;
            student.DistrictId = studentDto.DistrictId;
            student.GenderId = studentDto.GenderId;

            if (studentDto.Image != null)
            {
                var fileName = $"{Guid.NewGuid()}{Path.GetExtension(studentDto.Image.FileName)}";
                var path = Path.Combine(_env.WebRootPath, "Uploads", fileName);
                using var stream = new FileStream(path, FileMode.Create);
                await studentDto.Image.CopyToAsync(stream);
                student.Image = fileName;
            }

            await _context.SaveChangesAsync();
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null) return NotFound();

            if (!string.IsNullOrEmpty(student.Image))
            {
                string filePath = Path.Combine(_env.WebRootPath, "api/Uploads", student.Image);
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                }
            }

            _context.Students.Remove(student);
            _context.SaveChanges();
            return Ok("Deleted successfully");
        }
    }
}
