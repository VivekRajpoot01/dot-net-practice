using System;

public class Q19
{
    public static double FeetToCm(int feet)
    {
        return Math.Round(feet * 30.48, 2, MidpointRounding.AwayFromZero);
    }

    public static void Main(string[] args)
    {
        int feet = int.Parse(Console.ReadLine());
        Console.WriteLine(FeetToCm(feet));
    }
}