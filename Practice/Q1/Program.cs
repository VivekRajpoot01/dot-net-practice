public class Computer
{
    public string Processor {get; set;}
    public int RamSize{get; set;}
    public int HardDiskSize{get; set;}
    public int GraphicCard{get; set;}
}

public class Desktop: Computer
{
    public int MonitorSize{get; set;}
    public int PowerSupplyVolt{get; set;}

    public double DesktopPriceCalculation()
    {
        int processorCost = 0;
        if(Processor == "i3")
        {
            processorCost = 1500;
        }else if(Processor == "i5"){
            processorCost = 3000;
        }else if(Processor == "i7")
        {
            processorCost = 4500;
        }
        double price = processorCost +(RamSize * 200) + (HardDiskSize * 1500)+(GraphicCard * 2500)+(MonitorSize * 250)+(PowerSupplyVolt * 20);
        return price;
    }

    // public enum ProcessorCost
    // {
    //     i3 = 1500,
    //     i5 = 3000,
    //     i7 = 4500
    // }
}

public class Program
{
    public static void Main()
    {
        Desktop desktopObj = new Desktop();

        Console.WriteLine("Enter the processor");
        desktopObj.Processor = Console.ReadLine();


        Console.WriteLine("Enter the ram size");
        desktopObj.RamSize = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the hard disk size");
        desktopObj.HardDiskSize = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the graphic card size");
        desktopObj.GraphicCard = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the monitor size");
        desktopObj.MonitorSize = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the power supply volt");
        desktopObj.PowerSupplyVolt = int.Parse(Console.ReadLine());

        //Output
        Console.WriteLine($"Desktop price is {desktopObj.DesktopPriceCalculation()}");
    }
}