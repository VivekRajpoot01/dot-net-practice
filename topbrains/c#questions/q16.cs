using System;
using System.Linq;

public class Q16
{
    public static int SumParsed(string[] tokens)
    {
        return tokens.Sum(t => int.TryParse(t, out int val) ? val : 0);
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] tokens = Console.ReadLine().Split(' ');

        Console.WriteLine(SumParsed(tokens));
    }
}