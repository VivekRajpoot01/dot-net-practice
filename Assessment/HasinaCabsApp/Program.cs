// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace HasinaCabsApp;

public class Program{
    public static void Main()
    {
        CabDetails CabDetailsObj = new CabDetails();

        Console.Write("Enter the booking ID: ");
        CabDetailsObj.BookingId = Console.ReadLine();

        if (CabDetailsObj.ValidateBookingID())
        {
            Console.Write("Enter the Cab Type Type (HatchBack, Sedan, SUV): ");
            CabDetailsObj.CabType = Console.ReadLine();

            Console.Write("Enter the Distance in km: ");
            CabDetailsObj.Distance = Double.Parse(Console.ReadLine());

            Console.Write("Enter the waiting time in minutes: ");
            CabDetailsObj.WaitingTime = int.Parse(Console.ReadLine());

            //OUTPUT
            Console.WriteLine("=========================OUTPUT==============================");
            Console.Write($"The fare amount is {Math.Round(CabDetailsObj.CalculateFareAmount(),2)}");
        }
        else
        {
            Console.WriteLine("Invalid Booking ID");
        }
        
    }
}
