namespace OrderService.Services
{
    public interface IProductServiceClient
    {
        Task<bool> ReserveStockAsync(int productId, int quantity);
        Task<bool> CheckAvailabilityAsync(int productId, int quantity);
    }
}
