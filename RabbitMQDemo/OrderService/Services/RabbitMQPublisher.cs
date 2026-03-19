using RabbitMQ.Client;
using System.Text;
using System.Text.Json;
using OrderService.Models;

namespace OrderService.Services
{
    public class RabbitMQPublisher
    {
        private readonly ConnectionFactory _factory;

        public RabbitMQPublisher()
        {
            _factory = new ConnectionFactory()
            {
                HostName = "localhost"
            };
        }

        public async Task PublishOrderAsync(Order order)
        {
            await using var connection = await _factory.CreateConnectionAsync();
            await using var channel = await connection.CreateChannelAsync();

            await channel.QueueDeclareAsync(
                queue: "orderQueue",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null
            );

            var message = JsonSerializer.Serialize(order);
            var body = Encoding.UTF8.GetBytes(message);

            await channel.BasicPublishAsync(
                exchange: "",
                routingKey: "orderQueue",
                body: body
            );

            Console.WriteLine($"Order Sent => Price: {order.Price}");
        }
    }
}