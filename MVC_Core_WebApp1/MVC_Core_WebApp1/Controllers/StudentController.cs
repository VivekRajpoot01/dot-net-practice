using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Core_WebApp1.Models;

namespace MVC_Core_WebApp1.Controllers
{
    public class StudentController : Controller
    {
        StudentRepo sRepo = null;

        public StudentController()
        {
            sRepo = new StudentRepo();
        }
        public string[] GetAllCities()
        {
            return new string[] { "Pune", "Mumbai", "Lucknow", "Noida", "Delhi", "Calcutta", "Kolkata", "Chennai" };
        }
        // GET: Studentcs
        public ActionResult Index()
        {
            List<Student> sList = sRepo.ShowAllData();
            return View(sList);
        }

        // GET: Studentcs/Details/5
        public ActionResult Details(int id)
        {
            Student s = sRepo.ShowDetailsByID(id);
            return View(s);
        }

        // GET: Studentcs/Details/5
        [Route("StudentInfo/")]
        public ActionResult Details1(int rollNo)
        {
            Student s = sRepo.ShowDetailsByID(rollNo);
            return View(s);
        }

        // GET: Studentcs/Details/5
        public ActionResult StudentDetailsByName(string Name)
        {
            return View();
        }


        // GET: Studentcs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Studentcs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student s1)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    sRepo.AddData(s1);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Studentcs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Studentcs/Edit/5
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

        // GET: Studentcs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Studentcs/Delete/5
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
