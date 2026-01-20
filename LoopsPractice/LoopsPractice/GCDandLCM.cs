using System;
using System.Media;

namespace LoopsPractice;

public class GCDandLCM
{
    public static void Run()
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        for (int i = 1; i <= 10; i++)
            {
            Console.WriteLine("Beep number {0}.", i);
            Console.Beep();
            //SystemSounds.Beep.Play();
            
        }
    }
}
