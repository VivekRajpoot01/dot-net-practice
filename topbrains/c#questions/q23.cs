using System;
using System.Linq;

public class Program
{
    public static int SumIntegers(object[] values)
    {
        return values.Sum(v => v is int x ? x : 0);
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        object[] values = Console.ReadLine()
            .Split(' ')
            .Select(v =>
                int.TryParse(v, out int i) ? (object)i :
                bool.TryParse(v, out bool b) ? (object)b :
                v == "null" ? null : (object)v)
            .ToArray();

        Console.WriteLine(SumIntegers(values));
    }
}