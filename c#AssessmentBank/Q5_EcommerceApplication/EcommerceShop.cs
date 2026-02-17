public class EcommerceShop
{
    public string UserName {get; set;} 
    public double WalletBalance {get; set;}
    public double TotalPurchaseAmount {get; set;}


    public static EcommerceShop MakePayment(string name, double balance, double amount)
    {
        if (balance < amount)
        {
            throw new InsufficientBalanceException("Insufficient balance in your digital wallet");
        }
        return new EcommerceShop
        {
            UserName = name,
            WalletBalance = balance - amount,
            TotalPurchaseAmount = amount
        };
    }
}

public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string msg): base(msg)
    {
        
    }
}

