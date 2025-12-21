using System;

namespace LoopsPractice;

public class ArmstrongNumber
{
    public static void Run()
    {
        Console.WriteLine("Program to check Armstrong Number");
        Console.WriteLine("------------------------------------");

        Console.Write("Enter a number: ");
        string? input = Console.ReadLine();

        if(!int.TryParse(input,out int n))
        {
            Console.WriteLine("Enter a valid number");
            return;
        }

        if (n <= 0)
        {
            Console.WriteLine("Enter a positive number");
            return;
        }

        int num = n;
        int sum=0;
        int count=0;
        while (num != 0)
        {
            int x = num%10;
            count++;
            num/=10;
        }
        
        num=n;
        while (num != 0)
        {
            int digit = num%10;
            int power = 1;

            for(int i=0; i<count; i++)
            {
                power *= digit;
            }
            sum +=power;

            num /= 10;
        }

        if (sum == n)
        {
            Console.WriteLine("Armstrong Number!");
        }
        else
        {
            Console.WriteLine("Not a Armstrong Number!");
        }
    }
}
