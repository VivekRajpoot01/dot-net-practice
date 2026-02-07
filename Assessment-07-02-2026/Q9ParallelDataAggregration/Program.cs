namespace Q9ParallelDataAggregration;

public class Program
{
    class Program
{
    public static void Main()
    {
        var sales = new List<Sale>
        {
            new Sale { Region = "North", Category = "A", Amount = 100, Date = new DateTime(2026, 1, 1) },
            new Sale { Region = "North", Category = "B", Amount = 200, Date = new DateTime(2026, 1, 2) },
            new Sale { Region = "South", Category = "A", Amount = 300, Date = new DateTime(2025, 1, 3) },
            new Sale { Region = "South", Category = "B", Amount = 400, Date = new DateTime(2025, 1, 1) },
            
        };

        var totalSalesByRegion = sales.AsParallel()
            .GroupBy(s => s.Region)
            .Select(g => new { Region = g.Key, TotalSales = g.Sum(s => s.Amount) })
            .OrderBy(r => r.Region)
            .ToList();

        var topCategoryPerRegion = sales.AsParallel()
            .GroupBy(s => s.Region)
            .Select(g => new
            {
                Region = g.Key,
                TopCategory = g.GroupBy(s => s.Category)
                    .OrderByDescending(c => c.Sum(s => s.Amount))
                    .First().Key
            })
            .OrderBy(r => r.Region)
            .ToList();

        var bestSalesDayOverall = sales.AsParallel()
            .GroupBy(s => s.Date)
            .Select(g => new { Date = g.Key, TotalSales = g.Sum(s => s.Amount) })
            .OrderByDescending(d => d.TotalSales)
            .First();

        Console.WriteLine("Total Sales by Region:");
        foreach (var region in totalSalesByRegion)
        {
            Console.WriteLine($"{region.Region}: {region.TotalSales}");
        }

        Console.WriteLine("\nTop Category per Region:");
        foreach (var region in topCategoryPerRegion)
        {
            Console.WriteLine($"{region.Region}: {region.TopCategory}");
        }

        Console.WriteLine($"\nBest Sales Day Overall: {bestSalesDayOverall.Date} - {bestSalesDayOverall.TotalSales}");
    }
}
}