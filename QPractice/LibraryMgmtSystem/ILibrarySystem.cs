using System;

namespace LibraryMgmtSystem;

public interface ILibrarySystem
{
    void AddBook(IBook book, int quantity);
    void RemoveBook(IBook book, int quantity);
    int CalculateTotal();
    List<(string category, int totalPrice)> CategoryTotalPrice();
    List<(string title, int quantity, int price)> BookInfo();
    List<(string category, string author, int totalQuantity)> CategoryAndAuthorWithCount();
}
