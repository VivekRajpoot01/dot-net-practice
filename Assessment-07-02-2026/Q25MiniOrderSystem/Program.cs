namespace Q25MiniOrderSystem;
public class Program
{
    public static void Main()
    {
        try
        {
            var cust = new Customer("C001", "Jin");
            var prod1 = new Product("P001", "Product 1", 100, 10);
            var prod2 = new Product("P002", "Product 2", 200, 20);

            var order = new Order(cust);
            order.AddToCart(prod1, 2);
            order.AddToCart(prod2, 1);
            order.PlaceOrder();
            order.MakePayment(order.TotalAmount);

            Console.WriteLine($"Order placed successfully. Invoice Number: {order.InvoiceNumber}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}