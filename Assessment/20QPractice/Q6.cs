using System;

namespace _20QPractice;

public class Q6
{
    public static void Run()
    {
        Console.WriteLine("==========Program to sum positive numbers only==========");
        Console.Write("Enter elements: ");

        List<int> lst = new List<int>();

        while (true)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }

            lst.Add(Convert.ToInt32(input)); 
        }

        int sum = 0;
        foreach(int elem in lst)
        {
            if (elem > 0)
            {
                sum+=elem;
            }else if (elem < 0)
            {
                continue;
            }
            else
            {
                break;
            }

        } 

        Console.WriteLine($"Sum of postive numbers before 0 is: {sum}");

    }
}
