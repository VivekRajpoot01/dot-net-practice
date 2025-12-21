using System;

namespace LoopsPractice;

public class FibonacciSeries
{
    public static void Run()
    {
        Console.WriteLine("Program to check the first n fibonacci series");
        Console.WriteLine("---------------------------------------");

        Console.Write("Enter the value of n: ");
        string? input = Console.ReadLine();

        if(!int.TryParse(input,out int n))
        {
            Console.WriteLine("Enter a valid Input");
            return;
        }

        // Fibonacci Number: F(n) = F(n-1)+F(n-2)
        if (n <= 0)
        {
            Console.WriteLine("Input should be greater than 0");
            return;
        }
        if (n == 1)
        {
            
            Console.Write(0+" ");
            return;
        }
        int first = 0;
        Console.Write(first+" ");
        int second = 1;
        Console.Write(second+" ");

        for(int i=2; i<n; i++)
        {
            

            int third = first+second;
            Console.Write(third+" ");

            first = second;
            second = third;

        }
    }
}
