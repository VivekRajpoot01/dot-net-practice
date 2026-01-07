using System;

namespace DigitalPettyCashLe;

public class Ledger<T> where T: Transaction
{
    private List<T> transHistory = new List<T>();

    public void AddEntry(T entry)
    {
        transHistory.Add(entry);
    }

    public List<T> GetTransactionByDate(DateTime date)
    {
        List<T> res = new List<T>();

        return res;
    }

    public int CalculateTotal()
    {
        int total = 0;

        foreach(T trans in transHistory)
        {
            total += trans.Amount;
        }

        return total;
    }


}
