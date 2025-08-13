using Microsoft.AspNetCore.Mvc;
using SSMS.API.Data;
using SSMS.API.Data.Entitities;
using SSMS.API.DTOs;

namespace SSMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = _context.Employees.Select(e => new
                {
                    e.Id,
                    e.FirstName,
                    e.MiddleName,
                    e.LastName,
                    e.Address,
                    e.Email,
                    e.Mobile,
                    e.CountryId,
                    e.StateId,
                    e.DistrictId,
                    e.GenderId,
                    e.Image,
                    Languages = _context.EmployeeLanguages.Where(x => x.EmployeeId == e.Id).ToList()
            })
                .ToList();

            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            var employee = _context.Employees.Where(e => e.Id == id).Select(e => new
                {
                    e.Id,
                    e.FirstName,
                    e.MiddleName,
                    e.LastName,
                    e.Address,
                    e.Email,
                    e.Mobile,
                    e.CountryId,
                    e.StateId,
                    e.DistrictId,
                    e.GenderId,
                    e.Image,
                    Languages = _context.EmployeeLanguages.Where(x=>x.EmployeeId == id).ToList()
                })
                .FirstOrDefault();

            return Ok(employee);
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody] EmployeeDTO employeedto)
        {
            var employee = new Employee
            {
                FirstName = employeedto.FirstName,
                MiddleName = employeedto.MiddleName,
                LastName = employeedto.LastName,
                Address = employeedto.Address,
                Email = employeedto.Email,
                Mobile = employeedto.Mobile,
                CountryId = employeedto.CountryId,
                StateId = employeedto.StateId,
                DistrictId = employeedto.DistrictId,
                GenderId = employeedto.GenderId,
                Image = employeedto.Image
            };

            _context.Employees.Add(employee);
            _context.SaveChanges();

            foreach (var langId in employeedto.Languages)
            {
                _context.EmployeeLanguages.Add(new EmployeeLanguage
                {
                    EmployeeId = employee.Id,
                    LanguageId = langId
                });
            }
            _context.SaveChanges();

            return Ok(employee);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, EmployeeDTO employeedto)
        {
            // Fetch existing employee from DB
            var employee = _context.Employees.Find(id);
            if (employee == null)
                return NotFound("Employee not found");

            // Update fields
            employee.FirstName = employeedto.FirstName;
            employee.MiddleName = employeedto.MiddleName;
            employee.LastName = employeedto.LastName;
            employee.Address = employeedto.Address;
            employee.Email = employeedto.Email;
            employee.Mobile = employeedto.Mobile;
            employee.CountryId = employeedto.CountryId;
            employee.StateId = employeedto.StateId;
            employee.DistrictId = employeedto.DistrictId;
            employee.GenderId = employeedto.GenderId;
            employee.Image = employeedto.Image;

            // Remove only languages related to this employee
            var existingLanguages = _context.EmployeeLanguages.Where(el => el.EmployeeId == id).ToList();
            _context.EmployeeLanguages.RemoveRange(existingLanguages);

            // Add new languages
            foreach (var langId in employeedto.Languages)
            {
                _context.EmployeeLanguages.Add(new EmployeeLanguage
                {
                    EmployeeId = id,
                    LanguageId = langId
                });
            }

            _context.SaveChanges();
            return Ok("Data updated successfully!");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteEmployeeById(int id)
        {
            var employee = _context.Employees.Find(id);
            var employeelanguages = _context.EmployeeLanguages.ToList();
            _context.EmployeeLanguages.RemoveRange(employeelanguages);
            _context.Employees.Remove(employee);
            _context.SaveChanges();

            return Ok("Data deleted successfully!");
        }
    }
}
