using Microsoft.AspNetCore.Mvc;
using SSMS.API.Data;
using SSMS.API.Data.Entitities;
using System.Text;

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
        public IActionResult AddStudent([FromBody] Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();

            return Ok(student);
        }

        [HttpPut]
        public IActionResult UpdateStudent([FromBody] Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            _context.Students.Remove(student);
            _context.SaveChanges();
            return Ok("Deleted successfully");
        }

        [HttpGet("search")]
        public IActionResult Search(string query)
        {
            if (string.IsNullOrEmpty(query))
                return Ok(_context.Students.ToList());

            return Ok(_context.Students.Where(s => s.Name.Contains(query) || s.Email.Contains(query)).ToList());
        }

        [HttpGet("paginated")]
        public IActionResult GetPaginated(int pageNumber = 1, int pageSize = 10)
        {
            var totalRecords = _context.Students.Count();
            var students =  _context.Students
                                    .Skip((pageNumber - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToList();

            var response = new
            {
                TotalRecords = totalRecords,
                PageNumber = pageNumber,
                PageSize = pageSize,
                Data = students
            };

            return Ok(response);
        }

        [HttpGet("export")]
        public IActionResult ExportCsv()
        {
            var csv = new StringBuilder();
            csv.AppendLine("Id,FirstName,Email,Mobile");

            var students = _context.Students.ToList();

            foreach (var student in students)
            {
                csv.AppendLine($"{student.Id},{student.Name},{student.Email},{student.Mobile}");
            }

            var bytes = Encoding.UTF8.GetBytes(csv.ToString());
            return File(bytes, "text/csv", "students.csv");
        }
    }
}
