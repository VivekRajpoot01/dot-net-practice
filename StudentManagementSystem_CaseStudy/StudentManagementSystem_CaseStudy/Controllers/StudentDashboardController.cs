using Microsoft.AspNetCore.Mvc;

namespace StudentManagementSystem_CaseStudy.Controllers
{
    public class StudentDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}
