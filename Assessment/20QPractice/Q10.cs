using System;

namespace _20QPractice;

public class Q10
{
    public static void Run()
    {
        Console.WriteLine("===============Program to simulate a bank Account===============");
        Console.WriteLine("Enter initial balance: ");
        long initialBalance = long.Parse(Console.ReadLine());

        Console.WriteLine("Enter transactions: ");
        List<int> transactionsList = new List<int>();

        long finalBal = initialBalance;

        while (true)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }
            transactionsList.Add(int.Parse(input)); 
        }

        foreach(var trans in transactionsList)
        {
            if (trans >= 0)
            {
                finalBal += trans;
            }
            else
            {
                if (finalBal>=Math.Abs(trans))
                {
                    finalBal += trans;
                }
                
            }
            



        }

        Console.WriteLine("===============");
        Console.Write($"Final Balance : {finalBal}");

    }
}
