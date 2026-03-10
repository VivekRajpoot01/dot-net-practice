using Microsoft.EntityFrameworkCore;
using MVC_Assessment_07_03_26.Models;

namespace MVC_Assessment_07_03_26.Data
{
    public class LibraryDbContext: DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

    }
}
