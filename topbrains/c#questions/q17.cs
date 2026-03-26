using System;
using System.Linq;

public abstract class Employee
{
    public abstract decimal GetPay();
}

public class HourlyEmployee : Employee
{
    private decimal rate;
    private decimal hours;

    public HourlyEmployee(decimal rate, decimal hours)
    {
        this.rate = rate;
        this.hours = hours;
    }

    public override decimal GetPay() => rate * hours;
}

public class SalariedEmployee : Employee
{
    private decimal monthlySalary;

    public SalariedEmployee(decimal monthlySalary)
    {
        this.monthlySalary = monthlySalary;
    }

    public override decimal GetPay() => monthlySalary;
}

public class CommissionEmployee : Employee
{
    private decimal commission;
    private decimal baseSalary;

    public CommissionEmployee(decimal commission, decimal baseSalary)
    {
        this.commission = commission;
        this.baseSalary = baseSalary;
    }

    public override decimal GetPay() => baseSalary + commission;
}

public class Program
{
    public static decimal TotalPay(string[] employees)
    {
        var total = employees
            .Select(e =>
            {
                var parts = e.Split(' ');
                return parts[0] switch
                {
                    "H" => new HourlyEmployee(decimal.Parse(parts[1]), decimal.Parse(parts[2])),
                    "S" => new SalariedEmployee(decimal.Parse(parts[1])),
                    "C" => new CommissionEmployee(decimal.Parse(parts[1]), decimal.Parse(parts[2])),
                    _ => null
                };
            })
            .Where(e => e != null)
            .Sum(e => e.GetPay());

        return Math.Round(total, 2, MidpointRounding.AwayFromZero);
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] employees = new string[n];
        for (int i = 0; i < n; i++)
            employees[i] = Console.ReadLine();

        Console.WriteLine(TotalPay(employees));
    }
}