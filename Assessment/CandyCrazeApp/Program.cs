// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace CandyCrazeApp;

public class Program
{
    public Candy CalculateDiscountedPrice(Candy candy)
    {
        candy.TotalPrice = candy.Quantity * candy.PricePerPiece;

        if(candy.Flavour == "Strawberry")
        {
            candy.Discount = candy.TotalPrice - (candy.TotalPrice*0.15);
        }else if(candy.Flavour == "Lemon")
        {
            candy.Discount = candy.TotalPrice - (candy.TotalPrice*0.10);
        }else if(candy.Flavour == "Mint")
        {
            candy.Discount = candy.TotalPrice - (candy.TotalPrice*0.05);
        }

        return candy;
        
    }
    public static void Main()
    {
        Candy candy = new Candy();
        Console.Write("Enter the flavour (Strawberry, Lemon or Mint): ");
        candy.Flavour = Console.ReadLine();

        Console.Write("Enter the quantity: ");
        candy.Quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the price per piece: ");
        candy.PricePerPiece = Convert.ToInt32(Console.ReadLine());

        if(candy.ValidateCandyFlavour())
        {
            Program program = new Program();
            candy = program.CalculateDiscountedPrice(candy);

            Console.Write($"Flavour: {candy.Flavour}\n");
            Console.Write($"Quantity: {candy.Quantity}\n");
            Console.Write($"Price Per Piece: {candy.PricePerPiece}\n");
            Console.Write($"Total Price: {candy.TotalPrice}\n");
            Console.Write($"Discount Price: {candy.Discount}\n");


        }
        else
        {
            Console.WriteLine("Invalid Flavour");
        }
    }
}
