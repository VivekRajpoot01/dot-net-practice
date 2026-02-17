public class Program
{
    public static SortedDictionary<string,long> itemDetails = new SortedDictionary<string,long>();

    public static void Main()
    {
        
    }

    public static Dictionary<string,long> FindItemDetails(long soldCount)
    {
        var items = new Dictionary<string,long>();
        foreach(KeyValuePair<string,long> kv in itemDetails)
        {
            if(kv.Value == soldCount)
            {
                items.Add(kv.Key,kv.Value);
            }
             
        }
        return items;
    }

    public static List<string> FindMinandMaxSoldItems()
    {
        if(itemDetails.Count == 0)
        {
            return new List<string>();
        }
        var res = itemDetails.OrderBy(kv => kv.Value).ToList();

        return new List<string>
        {
            res.First().Key,
            res.Last().Key
        };
        
    }

    public static List<KeyValuePair<string,long>> SortByCount()
    {
        return itemDetails.OrderBy(kv => kv.Value).ToList();
    } 
}