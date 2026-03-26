using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static int TotalSalary(int[] ids, Dictionary<int, int> dict)
    {
        return ids.Sum(id => dict.ContainsKey(id) ? dict[id] : 0);
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] ids = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int m = int.Parse(Console.ReadLine());
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < m; i++)
        {
            var parts = Console.ReadLine().Split(' ');
            dict[int.Parse(parts[0])] = int.Parse(parts[1]);
        }

        Console.WriteLine(TotalSalary(ids, dict));
    }
}