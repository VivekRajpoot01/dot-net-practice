using System;

namespace LibraryMgmtSystem;

public class LibrarySystem: ILibrarySystem
{
    private Dictionary<IBook,int> _books;

    public LibrarySystem()
    {
        _books = new Dictionary<IBook, int>();
    }


    public void AddBook(IBook book, int quantity)
    {
        _books.Add(book,quantity);
    }


    public void RemoveBook(IBook book, int quantity)
    {
        if (!_books.ContainsKey(book))
        {
            return;
        }
        _books[book] -= quantity;
        if (_books[book] <= 0)
        {
            _books.Remove(book);
        }
    }


    public int CalculateTotal()
    {
        int total = 0;
        foreach(var book in _books)
        {
            int bookPrice = book.Key.Price * book.Value;
            total += bookPrice;

        }

        return total;
        
    }


    public List<(string category, int totalPrice)> CategoryTotalPrice()
    {
        Dictionary<string,int> result = new Dictionary<string,int>();

        foreach(var book in _books)
        {
            string category = book.Key.Category;
            int price = book.Key.Price * book.Value;
            if (result.ContainsKey(category))
            {
                result[category] += price;
            }
            result.Add(category,price);
        }

        List<(string,int)> output = new List<(string,int)>();

        foreach(var r in result)
        {
            output.Add((r.Key,r.Value));
        }
        return output; 
    }


    public List<(string title, int quantity, int price)> BookInfo()
    {
        List<(string,int,int)> bookInfo = new List<(string,int,int)>();

        foreach(var book in _books)
        {
            bookInfo.Add((book.Key.Title,book.Value,book.Key.Price));
        }
        return bookInfo;
    }


    public List<(string category, string author, int totalQuantity)> CategoryAndAuthorWithCount()
    {
        
    }
}
