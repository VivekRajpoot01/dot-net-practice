using System;
using System.Linq;

public class Q12
{
    public static int SumPositiveUntilZero(int[] nums)
    {
        return nums
            .TakeWhile(x => x != 0)
            .Where(x => x > 0)
            .Sum();
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(SumPositiveUntilZero(nums));
    }
}