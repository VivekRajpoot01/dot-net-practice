using System;

namespace Q25MiniOrderSystem;

public class Payment
{
    public string PaymentID { get; set; }
    public Order Ord { get; set; }
    public double Amount { get; set; }

    public Payment(Order ord, double amount)
    {
        Ord = ord;
        Amount = amount;
        PaymentID = Guid.NewGuid().ToString();
    }
}
