using System;

namespace LibMgmtSystemApp;

public class Book
{
    /// <summary>
    /// Fields for the Book Class
    /// </summary>
    string title;
    string author;
    int numPages;
    DateTime dueDate;
    DateTime returnedDate;

    ///<summary>
    /// Default Constructor
    ///</summary>

    public Book()
    {
        
    }

    ///<summary>
    /// Parameterized Constructor
    /// </summary>

    public Book(string title, string author, int numPages, DateTime dueDate, DateTime returnedDate)
    {
        this.title = title;
        this.author = author;
        this.numPages = numPages;
        this.dueDate = dueDate;
        this.returnedDate = returnedDate;
    }

    ///<summary>
    /// Method to find the number of pages read per day
    /// </summary>
    /// <returns>Average no. of Pages</returns>


    public double AveragePagesReadPerDay(int daysToRead)
    {
        return numPages/daysToRead;
    }

    ///<summary>
    /// Method to calculate the late fee amount
    /// </summary>
    /// </returns>Late Fee</returns>

    public double CalculateLateFee(double dailyLateFeeRate)
    {
        int daysLate = (returnedDate -dueDate).Days;
        return daysLate*dailyLateFeeRate;
    }     
}
