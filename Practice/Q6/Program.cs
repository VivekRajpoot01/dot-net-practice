using System;
using System.Text.RegularExpressions;
public class Cab
{
    public string BookingID { get; set; }
    public string CabType { get; set; }
    public double Distance { get; set; }
    public int WaitingTime { get; set; }
}

public class CabDetails : Cab
{
    public bool ValidateBookingID()
    {
        // TODO: Check length == 6, starts with "AC", contains "@"
        Regex reg = new Regex("^AC@[0-9]{3}");
        if(BookingID.Length == 6 && reg.IsMatch(BookingID))
        {
            return true;
        }
        return false;
    }

    public double CalculateFareAmount()
    {
        // TODO: Use Math.Sqrt() for waiting charge
        double waitingCharge = Math.Sqrt(WaitingTime);

        int pricePerKm = 0;
        if(CabType == "Hatchback")
        {
            pricePerKm = 10;
        }else if(CabType == "Sedan")
        {
            pricePerKm = 20;
        }else if(CabType == "SUV")
        {
            pricePerKm = 30;
        }
        double fare = (Distance * pricePerKm)+waitingCharge;

        return fare;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
        
        // TODO: Input logic
        // Use Console.WriteLine($"The fare amount is {fare:0.00}"); for formatting

        Console.WriteLine("Enter the booking id");
        string bookingId = Console.ReadLine();

        CabDetails cabObj = new CabDetails();

        cabObj.BookingID = bookingId;
        if (cabObj.ValidateBookingID())
        {
            Console.WriteLine("Enter the cab type");
            cabObj.CabType = Console.ReadLine();

            Console.WriteLine("Enter the distance in km");
            cabObj.Distance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the waiting time in minutes");
            cabObj.WaitingTime = int.Parse(Console.ReadLine());

            double fare = cabObj.CalculateFareAmount();

            //Output
            Console.WriteLine($"The fare amount is {fare:0.00}");
        }
        else
        {
            Console.WriteLine("Invalid booking id");
        }


    }
}
