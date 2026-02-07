using System;

namespace Q25MiniOrderSystem;

public class Order
{
    public string OrderID { get; set; }
    public Customer Cust { get; set; }
    public List<OrderItem> Items { get; set; }
    public double TotalAmount { get; set; }
    public string InvoiceNumber { get; set; }
    public bool IsPaid { get; set; }

    public Order(Customer cust)
    {
        Cust = cust;
        Items = new List<OrderItem>();
        OrderID = Guid.NewGuid().ToString();
        InvoiceNumber = $"INV-{OrderID}";
    }

    public void AddToCart(Product prod, int qty)
    {
        Items.Add(new OrderItem(prod, qty));
    }

    public void PlaceOrder()
    {
        foreach (var item in Items)
        {
            item.Prod.DeductStock(item.Quantity);
            TotalAmount += item.GetTotalPrice();
        }
    }

    public void MakePayment(double amount)
    {
        if (amount < TotalAmount)
        {
            throw new ValidationException("Insufficient payment");
        }
        IsPaid = true;
    }
}
