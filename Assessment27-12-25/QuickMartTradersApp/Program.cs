// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace QuickMartTradersApp;
public class Program
{
    //SaleTransaction SaleTransactionObj = null;
    public static void Main()
    {
        int input = 0;

        while (input != 4)
        {
            Console.WriteLine("============================QuickMartTraders====================================");
            Console.Write("1. Create New Transaction (Enter Purchase & Selling Details) \n2. View Last Transaction \n3. Calculate Profit/Loss (Recompute & Print) \n4. Exit\n");
            input = int.Parse(Console.ReadLine());

            switch (input)
                {
                    case 1:
                        SaleTransaction SaleTransactionObj = new SaleTransaction();
                        SaleTransactionObj.CreateTransaction();
                        break;

                    case 2:
                        SaleTransaction.PrintLastTransaction();
                        break;

                    case 3:
                        SaleTransaction.RecalculateAndPrint();
                        break;

                    case 4:
                        Console.WriteLine("Thank You. Application Closed Normally.");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please select 1, 2, 3, or 4.");
                        break;
                }
        }
    }
}
