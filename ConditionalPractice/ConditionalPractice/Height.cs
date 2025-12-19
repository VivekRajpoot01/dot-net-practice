using System;

namespace ConditionalPractice;

public class Height
{
    public static void Run()
    {
        Console.Write("Enter height in cm:  ");
        int height = int.Parse(Console.ReadLine());

        if (height < 150)
        {
            Console.WriteLine("Dwarf!");
        }else if(height>=150 && height < 165)
        {
            Console.WriteLine("Average");
        }else if(height>=165 && height <= 190)
        {
            Console.WriteLine("Tall");
        }
        else
        {
            Console.WriteLine("Abnormal");
        }
    }
}
