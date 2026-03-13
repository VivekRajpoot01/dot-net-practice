using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public StudentsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET: api/students
        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return context.Students.ToList();
        }

        // GET: api/students/1
        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent(int id)
        {
            var student = context.Students.Find(id);

            if (student == null)
            {
                return NotFound();
            }

            return student;
        }

        // POST: api/students
        [HttpPost]
        public ActionResult<Student> CreateStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();

            return student;
        }

        // PUT: api/students/1
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student student)
        {
            if (id != student.Id)
            {
                return BadRequest();
            }

            context.Entry(student).State = EntityState.Modified;

            context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/students/5
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = context.Students.Find(id);

            if (student == null)
            {
                return NotFound();
            }

            context.Students.Remove(student);
            context.SaveChanges();

            return NoContent();
        }
    }
}