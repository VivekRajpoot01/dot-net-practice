using System;

namespace ConditionalPractice;

public class TriangleType
{
    public static void Run()
    {
        Console.WriteLine("Enter length of the Triangle to check whether it is Equilateral, Isosceles or Scalene");
        Console.Write("Enter length of side 1: ");
        int side1 = int.Parse(Console.ReadLine());

        Console.Write("\nEnter length of side 2: ");
        int side2 = int.Parse(Console.ReadLine());

        Console.Write("\nEnter length of side 3: ");
        int side3 = int.Parse(Console.ReadLine());

        if(side1==side2 && side2 == side3)
        {
            Console.Write("Equilateral Triangle");
        }

        if((side1==side2)&&(side3!=side1) || (side1==side3)&&(side2!=side1) || (side2==side3)&&(side1!=side2)) {
            Console.Write("Isosceles Triangle");
        }

        if(side1!=side2 && side2!=side3 && side3 != side1)
        {
            Console.Write("Scalene Triangle");
        }
    }
}
