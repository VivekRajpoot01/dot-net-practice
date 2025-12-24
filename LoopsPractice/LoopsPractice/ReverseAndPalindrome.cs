using System;

namespace LoopsPractice;

public class ReverseAndPalindrome
{
    public static void Run()
    {
        Console.WriteLine("Program to reverse an integer and check if it is Palindrome or not");

        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Enter a Positive Integer. Try Again!");
        }

        int rev = 0;
        int num = n;

        while (num != 0)
        {
            int digit = num%10;
            rev = rev*10+digit;
            //Console.WriteLine(rev);
            num /=10;
        }

        if (n == rev)
        {
            Console.WriteLine("Number is Palindrome.");
        }
        else
        {
            Console.WriteLine("Number is not Palindrome.");
        }

    }
}
