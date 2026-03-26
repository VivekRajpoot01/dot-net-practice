using System;
using System.Linq;

public class Q9
{
    public static int FinalBalance(int initialBalance, int[] transactions)
    {
        return transactions.Aggregate(initialBalance, (balance, t) =>
            t >= 0 ? balance + t : (balance + t >= 0 ? balance + t : balance)
        );
    }

    public static void Main(string[] args)
    {
        int initialBalance = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] transactions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(FinalBalance(initialBalance, transactions));
    }
}