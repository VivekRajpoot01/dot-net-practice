class Program
{
    static void Main()
    {
        BikeUtility.AddBikeDetails("Bike1", "Royal Enfield", 1200);
        BikeUtility.AddBikeDetails("Bike2", "Royal Enfield", 1100);
        BikeUtility.AddBikeDetails("Bike3", "Yamaha", 1000);
        BikeUtility.AddBikeDetails("Bike4","Yamaha",1000);

        var groupedBikes = BikeUtility.GroupBikeWithBrandName();

        foreach (var brand in groupedBikes)
        {
            Console.WriteLine("Brand: " + brand.Key);
            foreach (Bike bike in brand.Value)
            {
                Console.WriteLine("  Model: " + bike.Model + " Price per day: " + bike.PricePerDay);
            }
        }
    }
}