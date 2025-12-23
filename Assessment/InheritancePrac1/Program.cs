// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using InheritancePrac1;
public class Program
{
    public static void Main()
    {
        Desktop desktop = new Desktop();

        Laptop laptop = new Laptop();

        Console.WriteLine("\n\n-----------Program to Calculate Price for Desktop or Laptop----------------------");
        Console.Write("1. Desktop \n2. Laptop\n");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                Console.Write("Enter the processor (i3, i5, i7): ");
                desktop.Processor = Console.ReadLine();

                Console.Write("Enter the ram size in GB (4, 8, 16, 32, 64): ");
                desktop.RamSize = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the hard disk size (in TB): ");
                desktop.HardDiskSize = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the graphic card size (in GB): ");
                desktop.GraphicCard = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Monitor size (in inches): ");
                desktop.MonitorSize = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the power supply volt (240V): ");
                desktop.PowerSupplyVolt = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("----------------");
                Console.Write($"Desktop Price is: {desktop.DesktopPriceCalculation()}");
                break;

            case 2:
                Console.Write("Enter the processor (i3, i5, i7): ");
                laptop.Processor = Console.ReadLine();

                Console.Write("Enter the ram size in GB (4, 8, 16, 32, 64): ");
                laptop.RamSize = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the hard disk size (in TB): ");
                laptop.HardDiskSize = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the graphic card size (in GB): ");
                laptop.GraphicCard = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Display size (in inches): ");
                laptop.DisplaySize = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the power supply volt (240V): ");
                laptop.BatteryVolt = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("----------------");
                Console.Write($"Laptop Price is: {laptop.LaptopPriceCalculation()}");
                break;

            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
}
