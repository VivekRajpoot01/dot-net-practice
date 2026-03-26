using System;
using System.Collections.Generic;
using System.Linq;

public static class Extensions
{
    public static IEnumerable<T> DistinctByCustom<T, TKey>(this IEnumerable<T> source, Func<T, TKey> keySelector)
    {
        var seen = new HashSet<TKey>();
        foreach (var item in source)
        {
            if (seen.Add(keySelector(item)))
                yield return item;
        }
    }
}

public class Program
{
    public static string[] GetDistinctNames(string[] items)
    {
        return items
            .DistinctByCustom(s => s.Split(':')[0])
            .Select(s => s.Split(':')[1])
            .ToArray();
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] items = new string[n];
        for (int i = 0; i < n; i++)
            items[i] = Console.ReadLine();

        var result = GetDistinctNames(items);
        Console.WriteLine(string.Join(" ", result));
    }
}