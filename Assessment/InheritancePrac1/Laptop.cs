using System;

namespace InheritancePrac1;

public class Laptop: Computer
{
    public int DisplaySize {get; set;}

    public int BatteryVolt {get; set;}

    

    public double LaptopPriceCalculation()
    {
        double price = 0;
        int processorPrice = 0;

        if(Processor == "i3")
        {
            processorPrice = 2500;
        }else if(Processor == "i5")
        {
            processorPrice = 5000;
        }
        else
        {
            processorPrice = 6500;
        }

        price =  processorPrice + (RamSize *200) + (HardDiskSize * 1500) + (GraphicCard*2500) + (BatteryVolt*20) + (DisplaySize*250);
        return price;
    }
}
