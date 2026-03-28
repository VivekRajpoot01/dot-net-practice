using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        // Implement your code here
        private readonly ICourse _repo;

        public CourseController(ICourse repo)
        {
            _repo = repo;
        }

        [HttpPut("UpdateCourse")]
        public IActionResult UpdateCourse([FromBody] Course course)
        {
            var result = _repo.UpdateCourse(course);

            if (result)
                return Ok();

            return BadRequest();
        }

        [HttpGet("WithEnrollmentsAboveGrade/{grade}")]
        public IActionResult GetCourses(int grade)
        {
            var result = _repo.GetCoursesWithEnrollmentsAboveGrade(grade);

            if (result.Any())
                return Ok(result);

            return NotFound("No Records Found");
        }

        [HttpGet("ByInstructorName/{instructorName}")]
        public IActionResult GetByInstructor(string instructorName)
        {
            var result = _repo.GetCoursesByInstructorName(instructorName);

            if (result.Any())
                return Ok(result);

            return NotFound("No Records Found");
        }
    }
}
