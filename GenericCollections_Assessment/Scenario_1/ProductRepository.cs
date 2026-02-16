public class ProductRepository<T> where T : class, IProduct
{
    private List<T> _products = new List<T>();
    
    // TODO: Implement method to add product with validation
    public void AddProduct(T product)
    {
        // Rule: Product ID must be unique
        // Rule: Price must be positive
        // Rule: Name cannot be null or empty
        // Add to collection if validation passes

        if (product == null)
            throw new ArgumentNullException("Product cannot be null");

        if (string.IsNullOrWhiteSpace(product.Name))
            throw new Exception("Product name cannot be empty");

        if (product.Price <= 0)
            throw new Exception("Price must be positive");

        if (_products.Any(p => p.Id == product.Id))
            throw new Exception("Product ID must be unique");

        _products.Add(product);
        Console.WriteLine($"Product {product.Name} added successfully");
    }
    
    // TODO: Create method to find products by predicate
    public IEnumerable<T> FindProducts(Func<T, bool> predicate)
    {
        // Should return filtered products

         return _products.Where(predicate);
    }
    
    // TODO: Calculate total inventory value
    public decimal CalculateTotalValue()
    {
        // Return sum of all product prices
        return _products.Sum(p =>p.Price);
    }
}
