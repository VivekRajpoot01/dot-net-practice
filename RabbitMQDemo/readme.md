# RabbitMQ Demo (OrderService -> PaymentService)

This folder contains a simple RabbitMQ-based messaging demo using **two ASP.NET Web APIs**:

- **OrderService**: Produces (publishes) messages to RabbitMQ when an order is created.
- **PaymentService**: Consumes messages from RabbitMQ and processes payments (simulated).

The goal is to demonstrate **asynchronous communication** between microservices using RabbitMQ.

---

## Solution Structure

```text
RabbitMQDemo/
  RabbitMQDemo.slnx
  OrderService/
    OrderService.csproj
    Program.cs
    Controllers/
    Models/
    Services/
  PaymentService/
    PaymentService.csproj
    Program.cs
    Controllers/
    Models/
    Services/
```

The solution includes these projects:

- `OrderService/OrderService.csproj`
- `PaymentService/PaymentService.csproj`

---

## Tech Stack

- .NET (Target Framework: `net10.0`)
- ASP.NET Core Web API
- RabbitMQ.Client (`7.2.1`)
- OpenAPI / Swagger (development)

---

## How the Demo Works (High Level)

### 1) OrderService (Publisher)
- Exposes HTTP endpoints (controller-based).
- When an order is placed, the service **publishes a message** to RabbitMQ (typically to an exchange or directly to a queue depending on implementation).
- PaymentService does not need to be online at the exact moment the message is produced (as long as RabbitMQ is up and the queue exists / is durable per your configuration).

### 2) PaymentService (Consumer)
- Runs a background consumer as a hosted service.
- It listens to the queue and **consumes messages** published by OrderService.
- In this project, the consumer is started via:

```csharp
builder.Services.AddHostedService<RabbitMQConsumer>();
```

So once PaymentService starts, it immediately begins consuming messages.

---

## Prerequisites

### Install / Run RabbitMQ
You need RabbitMQ running locally (or reachable from both services).

Common defaults:
- AMQP Port: `5672`
- Management UI: `15672`
- Default user/password (varies by setup): often `guest` / `guest` for local

If you use Docker, a typical command is:

```bash
docker run -it --rm \
  -p 5672:5672 -p 15672:15672 \
  --name rabbitmq \
  rabbitmq:management
```

Then open the management UI:
- http://localhost:15672

---

## Running the Services

You can run them from Visual Studio / Rider, or from the CLI.

### 1) Run PaymentService (Consumer) first
In one terminal:

```bash
cd RabbitMQDemo/PaymentService
dotnet run
```

PaymentService registers a hosted consumer (`RabbitMQConsumer`) and starts listening.

### 2) Run OrderService (Publisher)
In another terminal:

```bash
cd RabbitMQDemo/OrderService
dotnet run
```

---

## Testing the Flow

1. Start RabbitMQ
2. Start **PaymentService**
3. Start **OrderService**
4. Call the OrderService endpoint that creates/publishes an order message
5. Watch PaymentService logs to confirm it consumed the message

> Note: The exact endpoint route and request body depend on the controller implementation in `OrderService/Controllers`.

---

## OpenAPI / Swagger

Both services are configured with OpenAPI in development, via `AddOpenApi()` and `MapOpenApi()`.

Once running, you can typically find:
- OpenAPI endpoint (development only) exposed by the app (depends on your ASP.NET configuration)

If you want classic Swagger UI, you can add Swashbuckle, but currently the project uses the built-in OpenAPI mapping.

---

## Configuration

Each service includes:
- `appsettings.json`
- `appsettings.Development.json`

Typical RabbitMQ values you may configure (depending on how your services are written):
- Hostname (e.g., `localhost`)
- Port (`5672`)
- Username / Password
- Exchange / Queue name
- Routing key

> If you don’t see these in `appsettings.json` yet, they may be hardcoded in the service classes (publisher/consumer). Moving them into configuration is a good next step.

---

## Troubleshooting

### RabbitMQ connection errors
- Confirm RabbitMQ is running
- Confirm ports are reachable:
  - `5672` for AMQP
  - `15672` for management UI
- If using Docker on Windows/Mac, confirm Docker is running and ports are mapped properly.

### Messages not being consumed
- Ensure PaymentService is running (it hosts the consumer).
- Check the queue in the RabbitMQ Management UI:
  - Does the queue exist?
  - Are messages piling up (Ready > 0)?
- Ensure the publisher and consumer are using:
  - the same queue/exchange
  - the same routing key (if using direct/topic exchange)

---

## Notes / Improvements (Optional)

Ideas to extend the demo:
- Add DTOs for messages (OrderCreatedEvent, PaymentProcessedEvent)
- Add retry + dead-letter queue (DLQ)
- Add correlation IDs and structured logging
- Add health checks for RabbitMQ connectivity
- Make queue/exchange names configurable via `appsettings.json`

---

## Author

Demo created by **VivekRajpoot01** as part of `dot-net-practice`.
