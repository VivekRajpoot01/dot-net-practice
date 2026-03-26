using System;

public class Q6
{
    public static int Largest(int a, int b, int c)
    {
        return (a >= b && a >= c) ? a : (b >= c ? b : c);
    }

    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine(Largest(a, b, c));
    }
}