public abstract class BankAccount
{
    public int AccountNumber {get; set;}
    public string CustomerName {get; set;}
    public double Balance {get; set;}

    public BankAccount(int accNo, string cName, double balance)
    {
        AccountNumber = accNo;
        CustomerName = cName;
        Balance = balance;
    }

    public virtual void Deposit(int amount)
    {
        if (amount <= 0)
        {
            throw new InvalidTransactionException("Invalid amount");
        }
        Balance += amount;
    }
    public virtual void Withdraw(int amount)
    {
        if (Balance < amount)
        {
            throw new InsufficientBalanceException("Insufficient Balance");
        }
        Balance -= amount;
        
    }
    public abstract double CalculateInterest();
}