﻿using Microsoft.AspNetCore.Mvc;
using SSMS.API.Data;
using SSMS.API.Data.Entitities;

namespace SSMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DistrictsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDistricts()
        {
            return Ok(_context.Districts.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetDistrict(int id)
        {
            return Ok(_context.Districts.Find(id));
        }

        [HttpPut]
        public IActionResult UpdateDistrict(District district)
        {
            _context.Districts.Update(district);
            _context.SaveChanges();
            return Ok("Data updated successfully!");
        }

        [HttpPost]
        public IActionResult AddDistrict(District district)
        {
            _context.Districts.Add(district);
            _context.SaveChanges();
            return Ok("Data added successfully!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDistrictById(int id)
        {
            var district = _context.Districts.Find(id);
            _context.Districts.Remove(district);
            _context.SaveChanges();
            return Ok("Data deleted successfully!");
        }
    }
}
