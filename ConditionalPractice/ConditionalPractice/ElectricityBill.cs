using System;

namespace ConditionalPractice;

public class ElectricityBill
{
    public static void Run()
    {
        Console.Write("Enter the electricity reading: ");
        int reading = int.Parse(Console.ReadLine());

        double bill = 0;
        if (reading > 600)
        {
            int units = reading-600;
            double bill1 = units*2;
            bill += bill1;
            reading =600; 
        }

        if(reading>400 )
        {
            int units = reading-400;
            double bill1 = units*1.8;
            bill += bill1;
            reading =400;
        }

        if(reading>199)
        {
            int units = reading -199;
            double bill1 = units*1.5;
            bill+=bill1;
            reading =199;
        }
        // for remaining units less than 200
        double bill2 = reading*1.2;
        bill += bill2;

        if (bill > 400)
        {
            double surcharge =bill *0.15;
            bill +=surcharge;
        }
        
        Console.Write("Final bill for the given units: "+bill);
    }
}
