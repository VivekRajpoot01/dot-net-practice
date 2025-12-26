using System;

namespace _20QPractice;

public class Q5
{
    public static void Run()
    {
        Console.WriteLine("============Program to convert seconds into minutes and seconds as {m:ss} format ===========");
        Console.Write("Enter seconds: ");
        int totalSeconds = int.Parse(Console.ReadLine());

        int min = totalSeconds/60;
        int sec = totalSeconds%60;
        if (sec < 10)
        {
            Console.Write($"Output: {min}:0{sec}");
        }
        else
        {
            Console.Write($"Output: {min}:{sec}");
        }

        
    }
}
