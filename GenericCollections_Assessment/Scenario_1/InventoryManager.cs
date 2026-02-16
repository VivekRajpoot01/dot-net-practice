public class InventoryManager
{
    // TODO: Create method that accepts any IProduct collection
    public void ProcessProducts<T>(IEnumerable<T> products) where T : IProduct
    {
        // a) Print all product names and prices
        // b) Find the most expensive product
        // c) Group products by category
        // d) Apply 10% discount to Electronics over $500

        Console.WriteLine("All Products:");
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Name} - {p.Price}");
        }
            

        var max = products.OrderByDescending(p => p.Price).FirstOrDefault();
        Console.WriteLine($"Most Expensive: {max.Name} - {max.Price}");

        Console.WriteLine("Grouped by Category:");
        var grouped = products.GroupBy(p => p.Category);

        foreach (var group in grouped)
        {
            Console.WriteLine(group.Key);
            foreach (var item in group)
            {
                Console.WriteLine($"   {item.Name}");
            }
                
        }

        Console.WriteLine("\nApplying 10% discount to Electronics over $500:");
        foreach (var p in products
                 .Where(p => p.Category == Category.Electronics && p.Price > 500))
        {
            var discounted = new DiscountedProduct<T>(p, 10);
            Console.WriteLine(discounted);
        }
    }
    
    // TODO: Implement bulk price update with delegate
    public void UpdatePrices<T>(List<T> products, Func<T, decimal> priceAdjuster) 
        where T : IProduct
    {
        // Apply priceAdjuster to each product
        // Handle exceptions gracefully

        foreach (var p in products)
        {
            try
            {
                var newPrice = priceAdjuster(p);
                if (newPrice <= 0)
                {
                    throw new Exception("Invalid price update");
                }
                    

                p.GetType().GetProperty("Price").SetValue(p, newPrice);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating {p.Name}: {ex.Message}");
            }
        }
    }
}

// 5. TEST SCENARIO: Your tasks:
// a) Implement all TODO methods with proper error handling
// b) Create a sample inventory with at least 5 products
// c) Demonstrate:
//    - Adding products with validation
//    - Finding products by brand (for electronics)
//    - Applying discounts
//    - Calculating total value before/after discount
//    - Handling a mixed collection of different product types
