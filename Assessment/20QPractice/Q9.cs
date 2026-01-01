using System;

namespace _20QPractice;

public class Q9
{
    public static void Run()
    {
        Console.WriteLine("================Program to calculate GCD through Euclide Method===============");

        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write($"Gcd is: {gcd(num1,num2)}");
    }
    public static int gcd(int num1, int num2)
    {
        if (num2 == 0)
        {
            return num1;
        }
        return gcd(num2,num1%num2);
    } 
}
