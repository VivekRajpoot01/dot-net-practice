using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Models;
using OrderService.Services;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly RabbitMQPublisher _publisher;

        public OrderController()
        {
            _publisher = new RabbitMQPublisher();
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(Order order)
        {
            await _publisher.PublishOrderAsync(order);
            return Ok("Order sent to Payment Service via RabbitMQ");
        }
    }
}
