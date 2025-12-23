// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace CakeWorldApp;

public class Program
{
    public static void Main()
    {
        try
        {
        Cake cake = new Cake();

        Console.Write("Enter the flavour: ");
        cake.Flavour = Console.ReadLine().ToLower();

        Console.Write("Enter the quantity in kg: ");
        cake.QuantityInKg = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the price per kg: ");
        cake.PricePerKg = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Cake order was successful!");
        cake.CakeOrder();
        double cakePrice = cake.CalculatePrice();
        Console.WriteLine($"Price after discount is {cakePrice}");
        }
        catch(InvalidFlavourException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }catch(NegativeQuantityException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        
    }
}

