using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using StudentManagement.Models;
namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> _students = null;

        public StudentController()
        {
            if (_students == null)
            {
                _students = new List<Student>()
        {
            new Student {
                Id = 101,
                FullName = "Vivek Rajpoot",
                Email = "vivekrajput2515@gmail.com",
                DateOfBirth = new DateTime(2004, 07, 14),
                Course = "Computer Science"
            },
            new Student {
                Id = 102,
                FullName = "Ananya Sharma",
                Email = "ananya.sharma@example.com",
                DateOfBirth = new DateTime(2003, 05, 22),
                Course = "Information Technology"
            },
            new Student {
                Id = 103,
                FullName = "Arjun Mehra",
                Email = "arjun.m@outlook.com",
                DateOfBirth = new DateTime(2005, 01, 10),
                Course = "Data Science"
            },
            new Student {
                Id = 104,
                FullName = "Priya Verma",
                Email = "p.verma@gmail.com",
                DateOfBirth = new DateTime(2004, 11, 30),
                Course = "Cyber Security"
            },
            new Student {
                Id = 105,
                FullName = "Rohan Das",
                Email = "rohan.das@yahoo.com",
                DateOfBirth = new DateTime(2002, 08, 05),
                Course = "Artificial Intelligence"
            }
        };
            }
        }
        // GET: StudentController
        public ActionResult Index()
        {

            return View();
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View(_students);
        }
        [HttpGet]
        public ActionResult Create()
        {
            
            return View();
        }

        
        // GET: StudentController/Create
        public ActionResult Create(Student s)
        {
            _students.Add(s);
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
