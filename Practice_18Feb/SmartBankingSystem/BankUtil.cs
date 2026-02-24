public class BankUtil
{
    public static List<BankAccount> bankAccounts = null;

    public BankUtil()
    {
        if(bankAccounts == null)
        {
            bankAccounts = new List<BankAccount>();
        }
    }

    

}