using System;

class Program
{
    // Method 1: Swap using ref
    static void SwapUsingRef(ref int a, ref int b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
    }

    // Method 2: Swap using out
    static void SwapUsingOut(int a, int b, out int x, out int y)
    {
        a = a + b;
        b = a - b;
        a = a - b;

        x = a;
        y = b;
    }

    static void Main()
    {
        // Input for ref swap
        Console.WriteLine("Enter first number (ref):");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number (ref):");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("Before swap using ref:");
        Console.WriteLine("x = " + x + ", y = " + y);

        SwapUsingRef(ref x, ref y);

        Console.WriteLine("After swap using ref:");
        Console.WriteLine("x = " + x + ", y = " + y);

        Console.WriteLine();

        // Input for out swap
        Console.WriteLine("Enter first number (out):");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number (out):");
        int b = int.Parse(Console.ReadLine());

        int p, q;

        Console.WriteLine("Before swap using out:");
        Console.WriteLine("a = " + a + ", b = " + b);

        SwapUsingOut(a, b, out p, out q);

        Console.WriteLine("After swap using out:");
        Console.WriteLine("a = " + p + ", b = " + q);
    }
}
