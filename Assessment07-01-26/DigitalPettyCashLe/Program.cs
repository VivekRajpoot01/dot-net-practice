// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace DigitalPettyCashLe;

public class Program
{
    public static void Main()
    {


        while (true)
        {
            Console.WriteLine("==============Program to track Funds===========");
            Console.WriteLine("1. Add Income");
            Console.WriteLine("2. Add Expense");
            Console.WriteLine("3. Show Total");
            Console.WriteLine("4. Exit");
            Console.Write("Choose Option: ");

            int choice = int.Parse(Console.ReadLine());

            Ledger<IncomeTransaction> incomeTrans = new Ledger<IncomeTransaction>();
            Ledger<ExpenseTransaction> expenseTrans = new Ledger<ExpenseTransaction>();

            if (choice == 1)
            {
                Console.Write("Enter Id: ");
                int id = int.Parse(Console.ReadLine());


                Console.Write("Enter Amount: ");
                int amount = int.Parse(Console.ReadLine());

                Console.Write("Enter Description: ");
                string description = Console.ReadLine();

                Console.Write("Enter Source (e.g., Main Cash, Bank Transfer): ");
                string source = Console.ReadLine();

                IncomeTransaction income = new IncomeTransaction();

                income.ID = id;
                income.Amount = amount;
                income.Description = description;
                income.Source = source;
                income.Date = DateTime.Today;


                incomeTrans.AddEntry(income);



            }
            else if (choice == 2)
            {
                Console.Write("Enter Id: ");
                int id = int.Parse(Console.ReadLine());


                Console.Write("Enter Amount: ");
                int amount = int.Parse(Console.ReadLine());

                Console.Write("Enter Description: ");
                string description = Console.ReadLine();

                Console.Write("Add Category (e.g., Office, Travel, Food): ");
                string category = Console.ReadLine();

                ExpenseTransaction expense = new ExpenseTransaction();

                expense.ID = id;
                expense.Amount = amount;
                expense.Description = description;
                expense.Category = category;
                expense.Date = DateTime.Today;

                expenseTrans.AddEntry(expense);

            }
            else if (choice == 3)
            {
                int totalIncome = incomeTrans.CalculateTotal();
                int totalExpense = expenseTrans.CalculateTotal();

                if (totalIncome > totalExpense)
                {
                    Console.WriteLine($"Your Net Income is: {totalIncome - totalExpense}");
                }
                else
                {
                    Console.WriteLine("Your expense is greater than your income.");
                }

            }
            else if (choice == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again!");
            }

        }
    }
}
