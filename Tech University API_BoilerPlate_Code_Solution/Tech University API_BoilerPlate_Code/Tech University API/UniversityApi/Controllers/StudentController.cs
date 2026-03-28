using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // Implement your code here
        private readonly IStudent _repo;

        public StudentController(IStudent repo)
        {
            _repo = repo;
        }

        [HttpDelete("DeleteStudent/{studentId}")]
        public IActionResult Delete(int studentId)
        {
            var result = _repo.DeleteStudent(studentId);

            if (result)
                return Ok();

            return NotFound("No Records Found");
        }

        [HttpGet("ByCourseTitle/{courseTitle}")]
        public IActionResult GetStudents(string courseTitle)
        {
            var result = _repo.GetStudentsByCourseTitle(courseTitle);

            if (result.Any())
                return Ok(result);

            return NotFound("No Records Found");
        }
    }
}
