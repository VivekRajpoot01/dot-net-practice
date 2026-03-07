using Microsoft.AspNetCore.Mvc;
using MVC_Assessment_07_03_26.DAL;
using MVC_Assessment_07_03_26.Models;

namespace MVC_Assessment_07_03_26.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _repo;



        public BookController(IBookRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var books = _repo.GetAllBooks();
            return View(books);
        }

        public IActionResult List()
        {
            var books = _repo.GetAllBooks();
            return View(books);
        }

        public IActionResult Details(int id)
        {
            var book = _repo.GetBookById(id);

            if (book == null)
                return NotFound();

            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            _repo.AddBook(book);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            _repo.DeleteBook(id);
            return RedirectToAction("List");
        }
    }
}
