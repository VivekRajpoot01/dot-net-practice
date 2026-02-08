public class BikeUtility
{
    private static List<Bike> bikes = new List<Bike>();

    public static void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        Bike bike = new Bike(model, brand, pricePerDay);
        bikes.Add(bike);
    }

    public static SortedDictionary<string, List<Bike>> GroupBikeWithBrandName()
    {
        SortedDictionary<string, List<Bike>> result = new SortedDictionary<string, List<Bike>>();

        foreach (Bike bike in bikes)
        {
            if (!result.ContainsKey(bike.Brand))
            {
                result[bike.Brand] = new List<Bike>();
            }
            result[bike.Brand].Add(bike);
        }
        return result;
    }
}