using System;

namespace InheritancePrac1;

public class Desktop:Computer
{
    #region Properties
    public int MonitorSize {get; set;}

    public int PowerSupplyVolt {get; set;}

    #endregion
    public double DesktopPriceCalculation()
    {
        double price = 0;
        int processorPrice = 0;

        if(Processor == "i3")
        {
            processorPrice = 1500;
        }else if(Processor == "i5")
        {
            processorPrice = 3000;
        }
        else
        {
            processorPrice = 4500;
        }

        price =  processorPrice + (RamSize *200) + (HardDiskSize * 1500) + (GraphicCard*2500) + (PowerSupplyVolt*20) + (MonitorSize*250);
        return price;
    }
}
