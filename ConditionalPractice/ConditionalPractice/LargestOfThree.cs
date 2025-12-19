using System;

namespace ConditionalPractice;

public class LargestOfThree
{
    public static void Run()
    {
        Console.Write("Enter first number: ");
        int x1 = int.Parse(Console.ReadLine());
        Console.Write("\nEnter second number: ");
        int x2 = int.Parse(Console.ReadLine());
        Console.Write("\nEnter third number: ");
        int x3 = int.Parse(Console.ReadLine());

        int largest;
        if(x1>=x2 && x1 >= x3)
        {
            largest = x1;
        }else if(x2>=x1 && x2 >= x3)
        {
            largest = x2;
        }
        else
        {
            largest = x3;
        }

        Console.WriteLine("Largest number is: "+largest);
    }
}
