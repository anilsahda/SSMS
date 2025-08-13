using Microsoft.AspNetCore.Mvc;
using SSMS.API.Data;
using SSMS.API.Data.Entitities;

namespace SSMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QualificationsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public QualificationsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetQualifications()
        {
            return Ok(_context.Qualifications.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetQualification(int id)
        {
            return Ok(_context.Qualifications.Find(id));
        }

        [HttpPut]
        public IActionResult UpdateQualification(Qualification qualification)
        {
            _context.Qualifications.Update(qualification);
            _context.SaveChanges();
            return Ok("Data updated successfully!");
        }

        [HttpPost]
        public IActionResult AddQualification(Qualification qualification)
        {
            _context.Qualifications.Add(qualification);
            _context.SaveChanges();
            return Ok("Data added successfully!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteQualificationById(int id)
        {
            var qualification = _context.Qualifications.Find(id);
            _context.Qualifications.Remove(qualification);
            _context.SaveChanges();
            return Ok("Data deleted successfully!");
        }
    }
}
