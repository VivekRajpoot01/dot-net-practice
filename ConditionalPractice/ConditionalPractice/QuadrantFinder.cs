using System;

namespace ConditionalPractice;

public class QuadrantFinder
{
    public static void Run()
    {
        Console.WriteLine("Enter x and y coordinate to check in which quadrant they lies ");
        Console.Write("Enter x-coordinate: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("\nEnter y-coordinate: ");
        int y = int.Parse(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.Write("Coordinate lies in Quadrant 1");
        }
        if (x < 0 && y > 0)
        {
            Console.Write("Coordinate lies in Quadrant 2");
        }
        if (x < 0 && y < 0)
        {
            Console.Write("Coordinate lies in Quadrant 3");
        }
        if (x > 0 && y < 0)
        {
            Console.Write("Coordinate lies in Quadrant 4");
        }
        if (x == 0 && y == 0)
        {
            Console.Write("Origin! Doesn't belong to any coordinate ");
        }

    }
}
