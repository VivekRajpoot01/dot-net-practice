// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace KhataLedger;

public class Program
{
    public static void Main()
    {
        Dictionary<string,int> data = new Dictionary<string, int>()
        {
            { "Milk", 100 },
            { "Tea", 50 },
            { "Coffee", 100 },
            { "Sugar", 50 },
            { "Salt", 200 }

        };
        Khata khata = new Khata(data);

        Console.WriteLine($"Total Amount: {khata.getTotal()}");
        Console.WriteLine($"Repeated Amount Count: {khata.getRepeatAmount()}");
        
    }
}
