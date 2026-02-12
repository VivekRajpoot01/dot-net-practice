using System;

// TODO: Make this class Static
public class Movie
{
    // TODO: Implement Static Properties
    public static string MovieName{get; set;}
    public static string ScreenNumber {get; set;}
    public static double TicketPrice {get; set;}
    public static int NoOfTickets {get; set;}

}

public class MovieUtility
{
    public double CalculateTicketFare(string seatingType)
    {
        // TODO: Access Movie.TicketPrice, Movie.NoOfTickets directly
        double basePrice = Movie.TicketPrice*Movie.NoOfTickets;
        int additionalFee = 2 * Movie.NoOfTickets;

        double surCharge = 0;
        if(seatingType == "VIP")
        {
            surCharge = 0.5*basePrice;
        }else if(seatingType == "Premium")
        {
            surCharge = 0.3*basePrice; 
        }else if(seatingType == "Standard")
        {
            surCharge = 0;
        }

        return basePrice+additionalFee+surCharge;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Input Logic
        // TODO: Set Movie.MovieName = Console.ReadLine();
        // TODO: Create MovieUtility object and call method

        MovieUtility movieUObj = new MovieUtility();

        Console.WriteLine("Enter the movie name");
        Movie.MovieName = Console.ReadLine();

        Console.WriteLine("Enter the screen number");
        Movie.ScreenNumber = Console.ReadLine();

        Console.WriteLine("Enter the no of tickets");
        Movie.NoOfTickets = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the ticket price");
        Movie.TicketPrice = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the seating type");
        string seatingType = Console.ReadLine();

        double price = movieUObj.CalculateTicketFare(seatingType);

        //Output
        Console.WriteLine($"The ticket price is {price}");


    }
}