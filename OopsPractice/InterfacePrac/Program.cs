// See https://aka.ms/new-console-template for more information
namespace InterfacePrac;

public class Program
{
    public static void Main()
    {
        /*
        Console.WriteLine("Demo on Interface!");

        IAdd m1 = new MathClass();
        IAddSub m2 = new MathClass();
        IAll m3 = new MathClass();
        */

        // Approach 1
        Product pObj = new Product();
        pObj.ProdId = 101;
        pObj.Name = "Borosil Flask";
        pObj.Price = 850;

        // Approach 2
        //Object Init

        Product pObj1 = new Product(){ProdId = 102, Name="Luxow Filip", Price=25};

        // Collection Init
        List<Product> productList = new List<Product>()
        {
            new Product(){ProdId = 101, Name="Luxw Ailip", Price=225},
            new Product(){ProdId = 102, Name="Liw Raw", Price=125},
            new Product(){ProdId = 103, Name="Max Don", Price=250},
            new Product(){ProdId = 104, Name="Ramesh Badmosh", Price=155},
            new Product(){ProdId = 105, Name="Sophi Diljale", Price=925},
            new Product(){ProdId = 106, Name="Rahim Jadugar", Price=725}
        };

        foreach(var item in productList)
        {
            System.Console.WriteLine($"{item.ProdId}\t{item.Name}\t{item.Price}");
        }
    }
}
