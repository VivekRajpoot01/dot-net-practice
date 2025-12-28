using System;

namespace _20QPractice;

public class Q8
{
    public static void Run()
    {
        Console.WriteLine("================Sum only integer value from string array====================");

        Console.Write("Enter length of the array: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the elements: ");
        string[] arr = new string[n];
        
        int sum = 0;
        for(int i=0; i<n; i++)
        {
            string input = Console.ReadLine();

            if(int.TryParse(input, out int num))
            {
                sum+=num;
            }
        }

        Console.WriteLine($"Sum: {sum}");
    }
}
