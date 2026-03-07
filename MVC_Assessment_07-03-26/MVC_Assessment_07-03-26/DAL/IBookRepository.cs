using MVC_Assessment_07_03_26.Models;

namespace MVC_Assessment_07_03_26.DAL
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();

        Book GetBookById(int id);

        void AddBook(Book book);

        void DeleteBook(int id);
    }
}
