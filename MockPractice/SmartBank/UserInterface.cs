using System;

public class UserInterface
{
    public static void Main()
    {
        try{

            CreditRiskProcessor cObj = new CreditRiskProcessor();

            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter employment type: ");
            string employmentType = Console.ReadLine();

            Console.Write("Enter monthly income: ");
            double monthlyIncome = int.Parse(Console.ReadLine());

            Console.Write("Enter existing credit dues: ");
            double dues = double.Parse(Console.ReadLine());

            Console.Write("Enter credit score: ");
            int creditScore = int.Parse(Console.ReadLine());

            Console.Write("Enter number of loan defaults: ");
            int defaults = int.Parse(Console.ReadLine());


            cObj.ValidateCustomerDetails(age, employmentType,monthlyIncome,dues,creditScore,defaults);

            double cLimit = cObj.calculateCreditLimit(monthlyIncome,dues,creditScore,defaults);

            Console.WriteLine($"Customer Name: {name}");
            Console.WriteLine($"Approved Credit Limit: {cLimit}");
        }catch(InvalidCreditDataException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}