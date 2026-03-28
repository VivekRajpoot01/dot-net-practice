using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        // Implement your code here
        private readonly IInstructor _repo;

        public InstructorController(IInstructor repo)
        {
            _repo = repo;
        }

        [HttpPost("AddInstructor")]
        public IActionResult AddInstructor([FromBody] Instructor instructor)
        {
            var result = _repo.AddInstructor(instructor);

            if (result)
                return Ok();

            return BadRequest();
        }

        [HttpGet("WithCourseCountAbove/{count}")]
        public IActionResult GetAbove(int count)
        {
            var result = _repo.GetInstructorsWithCourseCountAbove(count);

            if (result.Any())
                return Ok(result);

            return NotFound("No Records Found");
        }

        [HttpGet("WithMostEnrollments")]
        public IActionResult GetMost()
        {
            var result = _repo.GetInstructorsWithMostEnrollments();

            if (result.Any())
                return Ok(result);

            return NotFound("No Records Found");
        }
    }
}
