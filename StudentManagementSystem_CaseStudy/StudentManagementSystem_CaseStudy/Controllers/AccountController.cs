using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem_CaseStudy.Data;
using StudentManagementSystem_CaseStudy.Models;
using StudentManagementSystem_CaseStudy.ViewModels;

namespace StudentManagementSystem_CaseStudy.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    FullName = model.FullName,
                    Email = model.Email,
                    Password = model.Password,
                    Role = model.Role
                };

                _context.Users.Add(user);
                _context.SaveChanges();

                return RedirectToAction("Login");
            }

            return View(model);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            var user = _context.Users
                .FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);

            if (user != null)
            {
                if (user.Role == "Teacher")
                    return RedirectToAction("Index", "TeacherDashboard");
                else
                    return RedirectToAction("Index", "StudentDashboard");
            }

            ViewBag.Error = "Invalid credentials";
            return View();
        }
    }
}
