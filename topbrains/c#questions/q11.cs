using System;
using System.Linq;
using System.Globalization;
using System.Text;

public class Q11
{
    public static string CleanName(string input)
    {
        var cleaned = new string(input.Trim()
            .Where((c, i) => i == 0 || c != input.Trim()[i - 1])
            .ToArray());

        return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cleaned.ToLower());
    }

    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Console.WriteLine(CleanName(input));
    }
}