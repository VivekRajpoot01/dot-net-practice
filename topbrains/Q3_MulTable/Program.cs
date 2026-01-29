using System;

class Program
{
    public int[] MultiplicationTable(int n, int upto)
    {
        int[] result = new int[upto];
        for (int i = 1; i <= upto; i++)
        {
            result[i - 1] = n * i;
        }
        return result;
    }

    public static void Main()
    {
        // Read inputs
        int n = int.Parse(Console.ReadLine());
        int upto = int.Parse(Console.ReadLine());

        // Create object to call non-static method
        Program p = new Program();

        int[] table = p.MultiplicationTable(n, upto);

        // Print result
        Console.WriteLine(string.Join(",", table));
    }
}