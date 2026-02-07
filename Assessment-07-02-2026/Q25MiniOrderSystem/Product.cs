using System;

namespace Q25MiniOrderSystem;

public class Product
{
    public string ProdID { get; set; }
    public string ProdName {get; set; }
    public double ProdPrice { get; set; }
    public int Stock{get; private set;}

    public Product(string id, string name, double price, int stock)
    {
        
        
        ProdID = id;
        ProdName = name;
        ProdPrice = price;
        Stock = stock;

        if(ProdPrice<=0 || stock <= 0)
        {
            throw new ValidationException("Invalid data");
        }
    }

    public void DeductStock(int qty)
    {
        if (qty > Stock)
        {
            throw new InvalidStockException($"Stock is not sufficient for Product {ProdName} ");
        }
        Stock -= qty;
    }
}
