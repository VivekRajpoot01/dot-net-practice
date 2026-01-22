// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Enter height in cm: ");
        // Take input from console
        int heightCm = int.Parse(Console.ReadLine());

        // Call method
        string result = HeightCategory.DisplayHeight(heightCm);


        // Print output
        Console.WriteLine(result);
    }
}