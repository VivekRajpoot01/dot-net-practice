using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderService.Data;
using OrderService.Dtos;
using OrderService.Models;
using OrderService.Services;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly OrderDbContext _context;
        private readonly IProductServiceClient _productClient;
        private readonly ILogger<OrdersController> _logger;

        public OrdersController(
            OrderDbContext context,
            IProductServiceClient productClient,
            ILogger<OrdersController> logger)
        {
            _context = context;
            _productClient = productClient;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDto>>> GetOrders(
            [FromQuery] string? customerId = null)
        {
            var query = _context.Orders
                .Include(o => o.Items)
                .AsQueryable();

            if (!string.IsNullOrEmpty(customerId))
            {
                query = query.Where(o => o.CustomerId == customerId);
            }
            var orders = await query
                            .OrderByDescending(o => o.OrderDate)
                            .ToListAsync();

            return Ok(orders.Select(MapToDto));

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDto>> GetOrder(int id)
        {
            var order = await _context.Orders
                .Include(o => o.Items)
                .FirstOrDefaultAsync(o => o.Id == id);

            if (order == null)
                return NotFound();

            return Ok(MapToDto(order));
        }
        [HttpPost]
        public async Task<ActionResult<OrderDto>> CreateOrder(CreateOrderDto createDto)
        {
            // Validate stock availability
            foreach (var item in createDto.Items)
            {
                var available = await _productClient.CheckAvailabilityAsync(
                    item.ProductId, item.Quantity);

                if (!available)
                {
                    return BadRequest($"Insufficient stock for product: {item.ProductName}");
                }
            }

            // Create order
            var order = new Order
            {
                CustomerId = createDto.CustomerId,
                CustomerEmail = createDto.CustomerEmail,
                OrderDate = DateTime.UtcNow,
                Status = OrderStatus.Pending,
                ShippingAddress = createDto.ShippingAddress,
                PaymentMethod = createDto.PaymentMethod,
                Items = createDto.Items.Select(i => new OrderItem
                {
                    ProductId = i.ProductId,
                    ProductName = i.ProductName,
                    UnitPrice = i.UnitPrice,
                    Quantity = i.Quantity
                }).ToList()
            };

            order.TotalAmount = order.Items.Sum(i => i.UnitPrice * i.Quantity);

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            // Reserve stock (saga pattern would be better, but simple for now)
            foreach (var item in createDto.Items)
            {
                await _productClient.ReserveStockAsync(item.ProductId, item.Quantity);
            }

            return CreatedAtAction(
                nameof(GetOrder),
                new { id = order.Id },
                MapToDto(order));
        }
        [HttpPut("{id}/cancel")]
        public async Task<IActionResult> CancelOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
                return NotFound();

            if (order.Status == OrderStatus.Shipped ||
                order.Status == OrderStatus.Delivered)
            {
                return BadRequest("Cannot cancel shipped or delivered orders");
            }

            order.Status = OrderStatus.Cancelled;
            await _context.SaveChangesAsync();

            return NoContent();
        }
        private OrderDto MapToDto(Order order)
        {
            return new OrderDto
            {
                Id = order.Id,
                CustomerId = order.CustomerId,
                CustomerEmail = order.CustomerEmail,
                OrderDate = order.OrderDate,
                Status = order.Status.ToString(),
                TotalAmount = order.TotalAmount,
                Items = order.Items.Select(i => new OrderItemDto
                {
                    ProductId = i.ProductId,
                    ProductName = i.ProductName,
                    UnitPrice = i.UnitPrice,
                    Quantity = i.Quantity
                }).ToList()
            };
        }
    }
}
