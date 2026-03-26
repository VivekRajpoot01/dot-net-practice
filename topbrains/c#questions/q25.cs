using System;

public class Program
{
    public static double CircleArea(double radius)
    {
        return Math.Round(Math.PI * radius * radius, 2, MidpointRounding.AwayFromZero);
    }

    public static void Main(string[] args)
    {
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine(CircleArea(radius));
    }
}