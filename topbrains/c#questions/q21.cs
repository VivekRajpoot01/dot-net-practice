using System;

public class Q21
{
    public static string FormatTime(int totalSeconds)
    {
        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;
        return $"{minutes}:{seconds:D2}";
    }

    public static void Main(string[] args)
    {
        int totalSeconds = int.Parse(Console.ReadLine());
        Console.WriteLine(FormatTime(totalSeconds));
    }
}