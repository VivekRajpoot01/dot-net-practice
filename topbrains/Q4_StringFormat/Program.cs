using System;
using System.Linq;
using System.Text.Json;

public record Student(string Name, int Score);

public class Program
{
    public static string Process(string[] items, int minScore)
    {
        return JsonSerializer.Serialize(
            items
                .Select(s => s.Split(':'))
                .Select(p => new Student(p[0], int.Parse(p[1])))
                .Where(s => s.Score >= minScore)
                .OrderByDescending(s => s.Score)
                .ThenBy(s => s.Name)
        );
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] items = new string[n];
        for (int i = 0; i < n; i++)
            items[i] = Console.ReadLine();
        int minScore = int.Parse(Console.ReadLine());

        Console.WriteLine(Process(items, minScore));
    }
}