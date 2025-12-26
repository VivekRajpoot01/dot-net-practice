using System;

namespace _20QPractice;

public class Q3
{
    public static void Run()
    {
        Console.WriteLine("=================Program to calculate height category================");
        Console.Write("Enter the height in centimeters: ");
        int height = int.Parse(Console.ReadLine());

        string category =  "";
        if (height < 150)
        {
            category = "Short";
        }else if(height>=150 && height < 180)
        {
            category = "Average";
        }
        else
        {
            category = "Tall";
        }

        Console.WriteLine("=====================Output=======================");
        Console.Write($"Height Category: {category}");
    }    
    
}
