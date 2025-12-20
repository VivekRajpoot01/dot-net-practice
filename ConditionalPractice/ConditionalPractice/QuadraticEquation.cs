using System;

namespace ConditionalPractice;

public class QuadraticEquation
{
    public static void Run()
    {
        Console.Write("Enter the value of coefficient of x^2 (a): ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("\nEnter value of coeffiecient of x (b): ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("\nEnter value of constant (c): ");
        int c = int.Parse(Console.ReadLine());

        // calculate d which is b^2-4*a*c
        double D = b*b-4*a*c;

        if (D > 0) // it will be having two real distinct roots
        {
            double first = (-b+Math.Sqrt(D))/2*a; // first real distinct root
            double second =(-b-Math.Sqrt(D))/2*a;  // second real distinct root
            
            Console.Write("First real and distinct root: "+first);
            Console.Write("\nSecond real and distinct root: "+second);

        }else if (D == 0) // it will be having one real root
        {
            double root = -b/2*a;
            Console.Write("As our d is equal to zero then it will be having one real root: "+root);

        }
        else
        {
            Console.Write("No real root exists");
        }
    }
}
