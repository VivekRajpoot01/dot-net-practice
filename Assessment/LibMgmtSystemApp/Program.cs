// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Diagnostics;
using System.Globalization;

namespace LibMgmtSystemApp;
public class Program
{
    public static void Main()
    {
        //Book bookObj = new Book();

        Console.Write("Enter the title: ");
        string title = Console.ReadLine();

        Console.Write("Enter the author: ");
        string author = Console.ReadLine();

        Console.Write("Enter the number of pages: ");
        int numPages = int.Parse(Console.ReadLine());

        Console.Write("Enter due date (MM/dd/yy): ");

        // taking input in specific format (MM/dd/yyyy)
        DateTime dueDate = DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy",CultureInfo.InvariantCulture);


        Console.Write("Enter return date (MM/dd/yy): ");

        // taking input in specific format (MM/dd/yyyy)
        DateTime returnedDate = DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy",CultureInfo.InvariantCulture);

        Console.Write("Enter the days to read: ");
        int daysToRead = int.Parse(Console.ReadLine());

        Console.Write("Enter the daily late feeRate: ");
        double lateFeeRate = double.Parse(Console.ReadLine());

        Book bookObj = new Book(title, author, numPages, dueDate, returnedDate);

        //Output
        Console.WriteLine("=================Output==================");
        Console.WriteLine($"Average Pages Read Per Day: {bookObj.AveragePagesReadPerDay(daysToRead)}");

        Console.WriteLine($"Late Fee: {bookObj.CalculateLateFee(lateFeeRate)}");

    }
}
