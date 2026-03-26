using System;
using System.Linq;

public class Q8
{
    public static int DigitSum(int x)
    {
        return x.ToString().Sum(c => c - '0');
    }

    public static bool IsPrime(int x)
    {
        if (x <= 1) return false;
        for (int i = 2; i * i <= x; i++)
            if (x % i == 0) return false;
        return true;
    }

    public static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ');
        int m = int.Parse(input[0]);
        int n = int.Parse(input[1]);

        int count = Enumerable.Range(m, n - m + 1)
            .Where(x => x > 0 && !IsPrime(x))
            .Count(x => DigitSum(x * x) == DigitSum(x) * DigitSum(x));

        Console.WriteLine(count);
    }
}