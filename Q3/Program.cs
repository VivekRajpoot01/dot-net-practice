using System;

public class Account
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public decimal Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            
        }
        else
        {
            throw new ArgumentException("Deposit amount must be positive.");
        }

        return Balance;
    }

    public decimal Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.");
        }else if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
        else
        {
            Balance -= amount;
        }
        
        return Balance;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Account accountObj = new Account();
        Console.WriteLine("1. Deposit\n2. Withdraw");

        Console.WriteLine("Enter the choice");
        int choice = int.Parse(Console.ReadLine());

        try
        {
            if(choice == 1)
            {
                Console.WriteLine("Enter the account number");
                accountObj.AccountNumber = Console.ReadLine();

                Console.WriteLine("Enter the balance");
                accountObj.Balance = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter the amount to be deposit");
                decimal deposit = decimal.Parse(Console.ReadLine());

                Console.WriteLine($"Balance amount {accountObj.Deposit(deposit)}");

            }else if(choice == 2)
            {
                Console.WriteLine("Enter the account number");
                accountObj.AccountNumber = Console.ReadLine();

                Console.WriteLine("Enter the balance");
                accountObj.Balance = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter the amount to be withdraw");
                decimal withdraw = decimal.Parse(Console.ReadLine());

                Console.WriteLine($"Balance amount {accountObj.Withdraw(withdraw)}");
            }
        }catch(ArgumentException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine($"Balance amount {accountObj.Balance}");
        }catch(InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine($"Balance amount {accountObj.Balance}");
        }


    }
}