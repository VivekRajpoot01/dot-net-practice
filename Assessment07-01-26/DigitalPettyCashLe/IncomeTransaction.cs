using System;

namespace DigitalPettyCashLe;

public class IncomeTransaction: Transaction, IReportable
{
    public string Source {get; set; }

    public void GetSummary()
    {
        Console.WriteLine($"==========================Income====================");
        Console.WriteLine($"Id: {ID} \nDate: {Date} \nAmount: {Amount} \nDescription: {Description} \nSource: {Source}");
    }
}
