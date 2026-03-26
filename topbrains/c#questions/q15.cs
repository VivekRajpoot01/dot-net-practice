using System;
using System.Linq;

public class Q15
{
    public static double? AverageNonNull(double?[] values)
    {
        var filtered = values.Where(v => v.HasValue).Select(v => v.Value).ToArray();
        if (filtered.Length == 0) return null;

        var avg = filtered.Average();
        return Math.Round(avg, 2, MidpointRounding.AwayFromZero);
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double?[] values = Console.ReadLine()
            .Split(' ')
            .Select(x => x == "null" ? (double?)null : double.Parse(x))
            .ToArray();

        var result = AverageNonNull(values);
        Console.WriteLine(result.HasValue ? result.Value.ToString() : "null");
    }
}