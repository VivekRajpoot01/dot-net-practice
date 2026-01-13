using System;

namespace KhataLedger;

public class Khata
{
    private static Dictionary<string,int> _khataRecord = new Dictionary<string, int>();

    public Khata()
    {
        
    }
    public Khata(Dictionary<string,int> record)
    {
        _khataRecord =new Dictionary<string, int>(record);
    }

    public int getTotal()
    {
        int sum = 0;
        foreach(var item in _khataRecord)
        {
            sum += item.Value;
        }

        return sum;
    }

    public int getRepeatAmount()
    {
        int count = 0;
        HashSet<int> hashset = new HashSet<int>();

        foreach(var item in _khataRecord)
        {

            if (!hashset.Add(item.Value))
            {
                count++;
            }
        }
        return count;
    }

    
}
