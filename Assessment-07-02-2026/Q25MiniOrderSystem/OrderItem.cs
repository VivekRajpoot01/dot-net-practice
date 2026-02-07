using System;

namespace Q25MiniOrderSystem;

public class OrderItem
{
    public Product Prod { get; set; }
    public int Quantity { get; set; }

    public OrderItem(Product prod, int qty)
    {
    if (qty <= 0)
        {
            throw new ValidationException("Quantity should be greater than zero");
        }

        Prod = prod;
        Quantity = qty;
    }

    public double GetTotalPrice()
    {
        return Prod.ProdPrice * Quantity;
    }
}
