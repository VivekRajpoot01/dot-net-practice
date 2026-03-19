using Microsoft.Extensions.Hosting;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;
using PaymentService.Models;

namespace PaymentService.Services
{
    public class RabbitMQConsumer : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost"
            };

            var connection = await factory.CreateConnectionAsync();
            var channel = await connection.CreateChannelAsync();

            await channel.QueueDeclareAsync(
                queue: "orderQueue",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null
            );

            var consumer = new AsyncEventingBasicConsumer(channel);

            consumer.ReceivedAsync += async (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var json = Encoding.UTF8.GetString(body);

                var order = JsonSerializer.Deserialize<Order>(json);

                Console.WriteLine($"Payment Started for Order ID: {order.Id}");
                Console.WriteLine($"Received Price: {order.Price}");

                if (order.Price > 2000)
                {
                    Console.WriteLine("High Value Payment → Extra Verification");
                }
                else
                {
                    Console.WriteLine("Normal Payment Processed");
                }

                await Task.CompletedTask;
            };

            await channel.BasicConsumeAsync(
                queue: "orderQueue",
                autoAck: true,
                consumer: consumer
            );

            Console.WriteLine("Payment Service Listening...");

            await Task.Delay(Timeout.Infinite, stoppingToken);
        }
    }
}