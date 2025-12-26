using System;

namespace _20QPractice;

public class Q7
{
    public static void Run()
    {
        Console.WriteLine("========Program to return the multiplication row for a number=========== ");

        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("For which number upto you want to print multiplication array: ");
        int mult = int.Parse(Console.ReadLine());

        int[] arr = new int[mult];

        for(int i=0; i<mult; i++)
        {
            arr[i] = n*(i+1);
        }

        Console.Write(string.Join(" ",arr)); 
    }
}
