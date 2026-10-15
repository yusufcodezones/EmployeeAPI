using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = new[]
            {
            new { Id = 1, Name = "Rahul" },
            new { Id = 2, Name = "Amit" }
        };

            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid employee ID.");

            return Ok(new { Id = id, Name = "Rahul" });
        }
    }
}
