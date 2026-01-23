// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

public class MergeSortedArrays
{
    public static T[] Merge<T>(T[] a, T[] b) where T : IComparable<T>
    {
        int n = a.Length;
        int m = b.Length;

        T[] mergedArr = new T[n + m];

        int i = 0, j = 0, k = 0;

        // Merge while both arrays have elements
        while (i < n && j < m)
        {
            if (a[i].CompareTo(b[j]) <= 0)
            {
                mergedArr[k++] = a[i++];
            }
            else
            {
                mergedArr[k++] = b[j++];
            }
        }

        // Copy remaining elements of a
        while (i < n)
        {
            mergedArr[k++] = a[i++];
        }

        // Copy remaining elements of b
        while (j < m)
        {
            mergedArr[k++] = b[j++];
        }

        return mergedArr;
    }

    // Example usage
    public static void Main()
    {
        int[] a = { 1, 3, 5, 7 };
        int[] b = { 2, 4, 6, 8 };

        int[] result = Merge(a, b);

        Console.WriteLine(string.Join(" ", result));
    }
}
