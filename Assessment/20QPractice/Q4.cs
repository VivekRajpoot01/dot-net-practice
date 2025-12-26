using System;

namespace _20QPractice;

public class Q4
{
public static void Run()
    {
        Console.WriteLine("============Program to check largest of three number==============");

        Console.Write("Enter num1: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter num2: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter num2: ");
        int num3 = int.Parse(Console.ReadLine());

        int largest = 0;

        if(num1>=num2 && num1 >= num2)
        {
            largest = num1;
        }else if (num2>=num1 && num2 >= num3)
        {
            largest = num2;
        }
        else
        {
            largest = num3;
        }
        Console.WriteLine($"Largest number is: {largest} ");
    }
}
