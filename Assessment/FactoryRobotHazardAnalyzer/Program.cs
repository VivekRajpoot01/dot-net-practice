// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace FactoryRobotHazardAnalyzer;

public class Program
{
    public static void Main()
    {
        Robot robotObj = new Robot();

        try
        {
            Console.Write("Enter arm pricision(0-1): ");
            double armPrecision = double.Parse(Console.ReadLine());

            Console.Write("Enter worker density (1-20): ");
            int workerDensity = int.Parse(Console.ReadLine());

            Console.Write("Enter machinery state (Worn, Faulty, Critical): ");
            string machineryState = Console.ReadLine();

            double output = robotObj.CalculateHazardRisk(armPrecision,workerDensity,machineryState);

            Console.WriteLine($"Robot Hazard Risk Score: {output}");
        }
        catch(RobotSafetyException e)
        {
            Console.WriteLine(e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}