using System;
using System.IO;
using System.Linq;

public class Q14
{
    public static void Main(string[] args)
    {
        var errors = File.ReadAllLines("log.txt")
                         .Where(line => line.Contains("ERROR"));

        File.WriteAllLines("error.txt", errors);
    }
}