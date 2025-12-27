using System;

namespace QuickMartTradersApp;

public class SaleTransaction
{
    #region Properties
    public string InvoiceNumber { get; set; }
    public string CustomerName { get; set; }
    public string ItemName { get; set; }
    public int Quantity { get; set; }
    public decimal PurchaseAmount { get; set; }
    public decimal SellingAmount { get; set; }
    public string ProfitOrLossStatus { get; set; }
    public decimal ProfitOrLossAmount { get; set; }
    public decimal ProfitMarginPercent { get; set; }

    #endregion

    public static SaleTransaction LastTransaction = null;
    public static bool HasLastTransaction = false; 


    public void CreateTransaction()
    {
        //SaleTransaction SaleTransactionObj = new SaleTransaction();

        Console.Write("Enter invoice number: ");
        InvoiceNumber = Console.ReadLine();
        if (InvoiceNumber == null)
        {
            Console.Write("InvoiceNo is empty");
            return;
        }

        Console.Write("Enter Customer Name: ");
        CustomerName = Console.ReadLine();

        Console.Write("Enter Item Name: ");
        ItemName = Console.ReadLine();


        Console.Write("Enter Quantity: ");
        Quantity = int.Parse(Console.ReadLine());
        if (Quantity <= 0)
        {
            Console.Write("Quantity must be greater than 0");
            return;
        }

        Console.Write("Enter Purchase Amount: ");
        PurchaseAmount = decimal.Parse(Console.ReadLine());
        if (PurchaseAmount <= 0)
        {
            Console.Write("Purchase amount must be greater than 0");
            return;
        }

        Console.Write("Enter Selling Amount: ");
        SellingAmount = decimal.Parse(Console.ReadLine());
        if (SellingAmount <= 0)
        {
            Console.Write("Selling amount must be greater than 0");
            return;
        }

        

        ComputeProfitLoss();

        LastTransaction = this;
        HasLastTransaction = true;


        Console.WriteLine("Transaction saved successfully.");

        Console.WriteLine($"Status: {ProfitOrLossStatus}");

        Console.WriteLine($"Profit/Loss Amount: {ProfitOrLossAmount}");

        Console.WriteLine($"Profit Margin: {ProfitMarginPercent}");



        


    }

    public void ComputeProfitLoss()
    {
        if(SellingAmount > PurchaseAmount)
        {
            ProfitOrLossStatus = "PROFIT";
            ProfitOrLossAmount = SellingAmount - PurchaseAmount;
        }else if(SellingAmount < PurchaseAmount)
        {
            ProfitOrLossStatus = "LOSS";
            ProfitOrLossAmount = PurchaseAmount - SellingAmount;
        }
        else
        {
            ProfitOrLossStatus = "BREAK-EVEN";
            ProfitOrLossAmount = 0;
        }

        if (PurchaseAmount > 0)
        {
            ProfitMarginPercent = Math.Round(ProfitOrLossAmount/PurchaseAmount*100,2);

        }
        else
        {
            ProfitMarginPercent = 0;
        }
        
    }

    public static void PrintLastTransaction()
    {
        if (!HasLastTransaction || LastTransaction == null)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            var t = LastTransaction;

            Console.WriteLine("======================Last Transaction=====================");

            Console.WriteLine($"Invoice No     : {t.InvoiceNumber}");

            Console.WriteLine($"Customer       : {t.CustomerName}");

            Console.WriteLine($"Item           : {t.ItemName}");

            Console.WriteLine($"Quantity       : {t.Quantity}");

            Console.WriteLine($"Purchase Amount: {t.PurchaseAmount}");

            Console.WriteLine($"Selling Amount : {t.SellingAmount}");

            Console.WriteLine($"Status         : {t.ProfitOrLossStatus}");

            Console.WriteLine($"Profit/Loss Amt: {t.ProfitOrLossAmount}");

            Console.WriteLine($"Profit Margin  : {t.ProfitMarginPercent}");
    }

    public static void RecalculateAndPrint()
    {
        if (!HasLastTransaction || LastTransaction == null)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            LastTransaction.ComputeProfitLoss();
            PrintLastTransaction();
    }
}
