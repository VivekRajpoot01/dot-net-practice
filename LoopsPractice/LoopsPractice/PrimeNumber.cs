using System;

namespace LoopsPractice;

public class PrimeNumber
{
    public static void Run()
    {
        Console.WriteLine("Program to check Prime number");
        Console.WriteLine("----------------------------");

        Console.Write("Enter a number: ");
        string? input = Console.ReadLine();

        if(!int.TryParse(input,out int n))
        {
            Console.WriteLine("Enter a valid number!");
            return;
        }

        if (n <= 0)
        {
            Console.WriteLine("Enter Positive Number. Try Again!");
            return;
        }

        if (n == 1)
        {
            Console.WriteLine("Special Case. Neither Prime nor Composite!");
            return;
        }

        bool is_prime = true;

        for(int i=2; i*i<=n; i++) // if one factor is greater than sq root then other would be less than sq root(n)
        {
            if (n % i == 0)
            {
                is_prime = false;
                break;
            }
        }
        if (is_prime)
        {
            Console.WriteLine("Prime Number!");
        }
        else
        {
            Console.WriteLine("Not a Prime Number!");
        }



    }
}
