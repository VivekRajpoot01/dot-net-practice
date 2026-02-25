using Microsoft.AspNetCore.Mvc;

namespace MVC_Core_WebApp1.Controllers
{
    public class CheckWordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private static readonly HashSet<string> offensiveWords = new HashSet<string>()
        {
            "badmos",
            "kutte",
            "stupid",
            "idiot",
            "janwar",
            "suar"
        };

        
        public IActionResult WordChecker(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return BadRequest("Input cannot be empty");

            if (offensiveWords.Contains(input.ToLower()))
                return Ok("Offensive word detected");

            return Ok($"Clean word: {input}");
        }
    }
}
