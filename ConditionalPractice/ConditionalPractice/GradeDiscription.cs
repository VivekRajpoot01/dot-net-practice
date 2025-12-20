using System;

namespace ConditionalPractice;

public class GradeDiscription
{
    public static void Run()
    {
        Console.WriteLine("Input Grade E,V,G,A,F to check desciption ");
        char ch = char.Parse(Console.ReadLine());

        switch (ch)
        {
            case 'E':
                Console.WriteLine("Excellent!");
                break;
            case 'V':
                Console.WriteLine("Very Good!");
                break;
            case 'G':
                Console.WriteLine("Good!");
                break;
            case 'A':
                Console.WriteLine("Average!");
                break;
            case 'F':
                Console.WriteLine("Fail");
                break;
            default:
                Console.WriteLine("Enter a Valid Grade!");
                break;                
        }
    }
}
