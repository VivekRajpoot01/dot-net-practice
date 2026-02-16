public class DiscountedProduct<T> where T : IProduct
{
    private T _product;
    private decimal _discountPercentage;
    
    public DiscountedProduct(T product, decimal discountPercentage)
    {
        // TODO: Initialize with validation
        // Discount must be between 0 and 100

        if (product == null)
            throw new ArgumentNullException("Product cannot be null");

        if (discountPercentage < 0 || discountPercentage > 100)
            throw new Exception("Discount must be between 0 and 100");

        _product = product;
        _discountPercentage = discountPercentage;
    }
    
    // TODO: Implement calculated price with discount
    public decimal DiscountedPrice => _product.Price * (1 - _discountPercentage / 100);
    
    // TODO: Override ToString to show discount details

    public override string ToString()
    {
        return $"{_product.Name} - Original: {_product.Price}"+
               $"Discount: {_discountPercentage}%"+
               $"Final: {DiscountedPrice}";
    }
}
