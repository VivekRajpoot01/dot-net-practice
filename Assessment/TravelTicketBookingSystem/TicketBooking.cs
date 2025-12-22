using System;

namespace TravelTicketBookingSystem;

public class TicketBooking
{
    public static void Run()
    {
        Console.WriteLine("Travel Ticket Booking & Fare Processing System");
        Console.WriteLine("---------------------------------");

        Console.Write("Enter passenger ID: ");
        int pId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter passenger name: ");
        string pName = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age <= 0)
        {
            Console.WriteLine("Age should be positive. Try Again!");
            return;
        }
        if (age < 5)
        {
            Console.WriteLine("Free Ticket - No Booking Required");
            return;
        }else if (age > 80)
        {
            Console.WriteLine("Medical Clearance Required");
            return;
        }


        Console.Write("Choose Travel type : \n1.Bus \n2.Train \n3.Flight\n");

        int type = Convert.ToInt32(Console.ReadLine());

        double multiplier = 0;
        string travelType = "";
        string travelClass = "";

        switch (type)
        {
            case 1:
                
                Console.Write("Choose class : \n1.Sleeper \n2.Seater\n");
                int choose1 = Convert.ToInt32(Console.ReadLine());
                travelType = "Bus";
                switch (choose1)
                {
                    case 1:
                        multiplier = 1.2;
                        travelClass = "Sleeper";
                        break;
                    case 2:
                        multiplier = 1.0;
                        travelClass = "Seater";
                        break;
                    default:
                        Console.WriteLine("Invalid Class Selected");
                        return;
                           
                }
                           
                break;                

                

            case 2:
                
                Console.Write("Choose class : \n1.General \n2.Sleeper \n3.AC\n");
                int choose2 = Convert.ToInt32(Console.ReadLine());
                travelType = "Train";
                

                switch (choose2)
                {
                    case 1:
                        multiplier = 1.0;
                        travelClass = "General";
                        break;
                    case 2:
                        multiplier = 1.2;
                        travelClass = "Sleeper";
                        break;
                    case 3:
                        multiplier = 1.6;
                        travelClass = "AC";
                        break;
                    default:
                        Console.WriteLine("Invalid Class Selected");
                        return;
                                
                }
                           
                break;

            case 3:
                
                Console.Write("Choose Class : \n1.Economy \n2.Business\n");
                int choose3 = Convert.ToInt32(Console.ReadLine());
                travelType = "Flight";
                

                switch (choose3)
                {
                    case 1:
                        multiplier = 2.5;
                        travelClass = "Economy";
                        break;
                    case 2:
                        multiplier = 3.5;
                        travelClass = "Business";
                        break;
                    default:
                        Console.WriteLine("Invalid Class Selected");
                        return;
                            
                }
                           
                break; 

            default:
                Console.WriteLine("Invalid Input");
                break;           
        }

        Console.Write("Enter Base fare: ");
        double baseFare = Convert.ToDouble(Console.ReadLine());

        Console.Write("Are you government employee (Enter true or false): ");
        string? govEmp = Console.ReadLine();
        bool gov_emp = false;
        govEmp = govEmp.ToLower();
        if(govEmp == "true")
        {
            gov_emp = true;
        }

        double fareClass = baseFare*multiplier;

        double discount = 0;

        if (age >= 60)
        {
            discount = 0.30;
        }else if (gov_emp == true)
        {
            discount = 0.15;
        }else if(age>=5 && age <= 12)
        {
            discount = 0.50;
        }

        double finalFare = fareClass - fareClass*discount;

        string bookingStatus = "";

        if (finalFare >= 10000)
        {
            if(travelType == "Flight")
            {
                bookingStatus = "Confirmed";
            }
            else
            {
                bookingStatus = "Waiting List";
            }
        }
        else
        {
            bookingStatus = "Confirmed";
        }


        //Output

        Console.WriteLine("\n-----------------Ticket Summary---------------- \n");
        Console.WriteLine($"Passenger id: {pId}");
        Console.WriteLine($"Passenger name: {pName}");
        Console.WriteLine($"Travel Type: {travelType}");
        Console.WriteLine($"Travel Class: {travelClass}");
        Console.WriteLine($"Base Fare: {baseFare}");
        Console.WriteLine($"Final Fare: {finalFare}");
        Console.WriteLine($"Discount Applied: {discount*100}%");
        Console.WriteLine($"Booking Status: {bookingStatus}"); 
    }
}
