using System;

namespace DigitalPettyCashLe;

public class ExpenseTransaction:Transaction, IReportable
{
    public string Category { get; set; }

    public void GetSummary()
    {
        Console.WriteLine($"==========================Expense====================");
        Console.WriteLine($"Id: {ID} \nDate: {Date} \nAmount: {Amount} \nDescription: {Description} \nSource: {Category}");
    }
}
