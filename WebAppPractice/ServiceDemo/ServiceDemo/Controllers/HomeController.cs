using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ServiceDemo.Models;
using ServiceDemo.Services;

namespace ServiceDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly MessageService _messageService;

        public HomeController(MessageService messageService)
        {
            _messageService = messageService;
        }
        public IActionResult Index()
        {
            string message = _messageService.GetMessage();
            int result = _messageService.AddNumbers(5, 10);

            ViewBag.Message = message;
            ViewBag.Sum = result;

            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


