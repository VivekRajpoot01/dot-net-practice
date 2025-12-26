using System;

namespace _20QPractice;

public class Q2
{
    public static void Run()
    {
        Console.WriteLine("==================Program to calculate centimeters from feet=====================");
        Console.Write("Enter the feet: ");
        int feet = int.Parse(Console.ReadLine());

        Console.Write("==================Output=================");

        Console.Write($"Output is: {30.48*feet}");
    }
}
