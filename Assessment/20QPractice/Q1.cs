using System;

namespace _20QPractice;

public class Q1
{
    public static void Run()
    {
        Console.Write("Enter the radius: ");
        int radius = int.Parse(Console.ReadLine());

        double area = Math.PI * radius * radius;

        Console.Write($"Area of circle is: {Math.Round(area,2)}");
    }
}
