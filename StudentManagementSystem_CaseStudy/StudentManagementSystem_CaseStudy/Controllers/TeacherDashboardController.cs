using Microsoft.AspNetCore.Mvc;

namespace StudentManagementSystem_CaseStudy.Controllers
{
    public class TeacherDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
