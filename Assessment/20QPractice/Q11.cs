using System;

namespace _20QPractice;

public class Q11
{
    public static void Run()
    {
        Console.WriteLine("==============Sum only integer value in the object array==============");

        Console.WriteLine("=============================================");

        Console.Write("Enter the length of the array: ");
        int n = int.Parse(Console.ReadLine()); 

        Console.WriteLine("Enter elements for the object array");
        object[] arr = new object[n];

        for(int i=0; i<n; i++)
        {
            string input = Console.ReadLine();
            if(int.TryParse(input,out int num))
            {
                arr[i] = num;
            }
            else
            {
                arr[i] = input;
            }
        }
        int sum = 0;

        foreach(var elem in arr)
        {
            if(elem is int x)
            {
                sum+=x;
            }
        }

        Console.WriteLine($"Sum of integer element is: {sum}"); 
    }
}
