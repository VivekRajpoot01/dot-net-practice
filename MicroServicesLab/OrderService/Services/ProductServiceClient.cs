using System.Text;
using System.Text.Json;

namespace OrderService.Services
{
    public class ProductServiceClient: IProductServiceClient
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<ProductServiceClient> _logger;

        public ProductServiceClient(
            HttpClient httpClient,
            ILogger<ProductServiceClient> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<bool> ReserveStockAsync(int productId, int quantity)
        {
            try
            {
                var content = new StringContent(
                    JsonSerializer.Serialize(quantity),
                    Encoding.UTF8,
                    "application/json");

                var response = await _httpClient.PutAsync(
                    $"/api/products/{productId}/stock",
                    content);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error reserving stock for product {ProductId}", productId);
                return false;
            }
        }

        public async Task<bool> CheckAvailabilityAsync(int productId, int quantity)
        {
            try
            {
                var response = await _httpClient.GetAsync(
                    $"/api/products/{productId}");

                if (!response.IsSuccessStatusCode)
                    return false;

                var product = await response.Content.ReadFromJsonAsync<ProductDto>();
                return product?.AvailableStock >= quantity;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error checking availability for product {ProductId}", productId);
                return false;
            }
        }
        private record ProductDto
        {
            public int Id { get; set; }
            public int AvailableStock { get; set; }
        }

    }
}
