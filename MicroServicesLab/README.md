# 🛒 ECommerce Microservices Lab

![.NET](https://img.shields.io/badge/.NET%208.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-4169E1?style=for-the-badge&logo=postgresql&logoColor=white)
![RabbitMQ](https://img.shields.io/badge/RabbitMQ-FF6600?style=for-the-badge&logo=rabbitmq&logoColor=white)
![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)

A hands-on **Microservices Architecture** lab built with **ASP.NET Core 8.0**, featuring an ECommerce system with multiple independent services communicating via **RabbitMQ (MassTransit)** and routed through an **Ocelot API Gateway**.

---

## 📖 Table of Contents

- [Architecture Overview](#-architecture-overview)
- [Services](#-services)
  - [API Gateway](#1--api-gateway)
  - [Product Service](#2--product-service)
  - [Order Service](#3--order-service)
  - [Inventory Service](#4--inventory-service)
- [Tech Stack](#-tech-stack)
- [Project Structure](#-project-structure)
- [Getting Started](#-getting-started)
  - [Prerequisites](#prerequisites)
  - [Running the Services](#running-the-services)
- [API Endpoints](#-api-endpoints)
- [Key Concepts Covered](#-key-concepts-covered)
- [Author](#-author)

---

## 🏗️ Architecture Overview

```
                        ┌─────────────────┐
                        │     Client      │
                        └────────┬────────┘
                                 │
                        ┌────────▼────────┐
                        │   API Gateway   │
                        │  (Ocelot)       │
                        │  Port: 5035     │
                        └──┬─────┬─────┬──┘
                           │     │     │
              ┌────────────┘     │     └────────────┐
              │                  │                   │
     ┌────────▼────────┐ ┌──────▼───────┐ ┌────────▼─────────┐
     │ Product Service  │ │ Order Service│ │Inventory Service │
     │   Port: 5136     │ │ Port: 5132   │ │   Port: 5005     │
     │   (PostgreSQL)   │ │              │ │                  │
     └────────┬─────────┘ └──────┬───────┘ └────────┬─────────┘
              │                  │                   │
              └──────────────────┼───────────────────┘
                                 │
                        ┌────────▼────────┐
                        │    RabbitMQ     │
                        │  (MassTransit)  │
                        └─────────────────┘
```

---

## 🔧 Services

### 1. 🚪 API Gateway

The **API Gateway** acts as the single entry point for all client requests. It routes incoming requests to the appropriate downstream microservice.

| Feature | Details |
|---------|---------|
| **Framework** | ASP.NET Core 8.0 (Minimal API) |
| **Gateway** | [Ocelot](https://github.com/ThreeMammals/Ocelot) |
| **Resilience** | [Polly](https://github.com/App-vNext/Polly) (via Ocelot.Provider.Polly) |
| **Logging** | [Serilog](https://serilog.net/) (Console Sink) |
| **Port** | `5035` |

### 2. 📦 Product Service

The **Product Service** manages the product catalog — full CRUD operations with PostgreSQL as the data store.

| Feature | Details |
|---------|---------|
| **Framework** | ASP.NET Core 8.0 (Controllers) |
| **Database** | PostgreSQL (via Npgsql + EF Core) |
| **ORM** | Entity Framework Core 8.0 |
| **Messaging** | MassTransit + RabbitMQ |
| **Health Checks** | `/health` endpoint |
| **Port** | `5136` |

**Key Components:**

| Component | Description |
|-----------|-------------|
| `Models/Product.cs` | Product entity with Id, Name, Description, Price, CategoryId, Stock, etc. |
| `Data/ProductDbContext.cs` | EF Core DbContext with Fluent API configuration & seed data |
| `Repositories/IProductRepository.cs` | Repository interface for product data access |
| `Repositories/ProductRepository.cs` | Repository implementation with full CRUD + stock management |
| `Controllers/ProductController.cs` | REST API controller with GET, POST, PUT, DELETE, and stock update endpoints |
| `Dtos/ProductDto.cs` | Response DTO for product data |
| `Dtos/CreatedProductDto.cs` | Request DTO for creating products |
| `Dtos/UpdateProductDto.cs` | Request DTO for updating products |

### 3. 🛍️ Order Service

The **Order Service** handles order placement and management. Currently set up with scaffolding and ready for business logic implementation.

| Feature | Details |
|---------|---------|
| **Framework** | ASP.NET Core 8.0 (Minimal API) |
| **Messaging** | MassTransit + RabbitMQ |
| **Port** | `5132` |

### 4. 📋 Inventory Service

The **Inventory Service** manages stock and inventory tracking. Currently set up with scaffolding and ready for business logic implementation.

| Feature | Details |
|---------|---------|
| **Framework** | ASP.NET Core 8.0 (Minimal API) |
| **Messaging** | MassTransit + RabbitMQ |
| **Port** | `5005` |

---

## 🛠️ Tech Stack

| Technology | Purpose |
|------------|---------|
| **ASP.NET Core 8.0** | Web framework for all microservices |
| **Entity Framework Core 8.0** | ORM for database operations (Product Service) |
| **PostgreSQL** | Relational database (Product Service) |
| **Ocelot** | API Gateway for request routing |
| **Polly** | Resilience & transient fault handling |
| **MassTransit** | Message broker abstraction |
| **RabbitMQ** | Message queue for inter-service communication |
| **Serilog** | Structured logging |
| **Swagger / OpenAPI** | API documentation & testing UI |

---

## 📁 Project Structure

```
MicroServicesLab/
├── ECommerce.slnx                  # Solution file
├── README.md                       # This file
│
├── ApiGateway/                     # 🚪 API Gateway Service
│   ├── ApiGateway.csproj
│   ├── Program.cs
│   ├── ApiGateway.http
│   ├── appsettings.json
│   └── appsettings.Development.json
│
├── ProductService/                 # 📦 Product Microservice
│   ├── ProductService.csproj
│   ├── Program.cs
│   ├── ProductService.http
│   ├── appsettings.json
│   ├── appsettings.Development.json
│   ├── Controllers/
│   │   └── ProductController.cs
│   ├── Models/
│   │   └── Product.cs
│   ├── Data/
│   │   └── ProductDbContext.cs
│   ├── Dtos/
│   │   ├── ProductDto.cs
│   │   ├── CreatedProductDto.cs
│   │   └── UpdateProductDto.cs
│   ├── Repositories/
│   │   ├── IProductRepository.cs
│   │   └── ProductRepository.cs
│   └── Properties/
│       └── launchSettings.json
│
├── OrderService/                   # 🛍️ Order Microservice
│   ├── OrderService.csproj
│   ├── Program.cs
│   ├── OrderService.http
│   ├── appsettings.json
│   └── appsettings.Development.json
│
└── InventoryService/               # 📋 Inventory Microservice
    ├── InventoryService.csproj
    ├── Program.cs
    ├── InventoryService.http
    ├── appsettings.json
    └── appsettings.Development.json
```

---

## 🚀 Getting Started

### Prerequisites

- [.NET SDK 8.0+](https://dotnet.microsoft.com/download)
- [PostgreSQL](https://www.postgresql.org/download/) (for Product Service)
- [RabbitMQ](https://www.rabbitmq.com/download.html) (for inter-service messaging)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or VS Code

### Database Setup

1. Install and start PostgreSQL
2. Update the connection string in `ProductService/appsettings.json` if needed:
   ```json
   {
     "ConnectionStrings": {
       "ProductDatabase": "Host=localhost;Port=5432;Database=ProductDb;Username=postgres;Password=postgres;"
     }
   }
   ```
3. The database and seed data will be created automatically on first run via `EnsureCreated()`

### Running the Services

**Option 1: Run the entire solution**
```bash
cd MicroServicesLab
dotnet build ECommerce.slnx
```

**Option 2: Run individual services**

```bash
# Terminal 1 — API Gateway
cd MicroServicesLab/ApiGateway
dotnet run

# Terminal 2 — Product Service
cd MicroServicesLab/ProductService
dotnet run

# Terminal 3 — Order Service
cd MicroServicesLab/OrderService
dotnet run

# Terminal 4 — Inventory Service
cd MicroServicesLab/InventoryService
dotnet run
```

### Access Swagger UI

Once the services are running, visit:

| Service | Swagger URL |
|---------|-------------|
| API Gateway | `http://localhost:5035/swagger` |
| Product Service | `http://localhost:5136/swagger` |
| Order Service | `http://localhost:5132/swagger` |
| Inventory Service | `http://localhost:5005/swagger` |

---

## 📡 API Endpoints

### Product Service (`/api/products`)

| Method | Endpoint | Description |
|--------|----------|-------------|
| `GET` | `/api/products` | Get all products |
| `GET` | `/api/products/{id}` | Get product by ID |
| `GET` | `/api/products/category/{categoryId}` | Get products by category |
| `POST` | `/api/products` | Create a new product |
| `PUT` | `/api/products/{id}` | Update a product |
| `DELETE` | `/api/products/{id}` | Delete a product |
| `PUT` | `/api/products/{id}/stock` | Update product stock |
| `GET` | `/health` | Health check |

### Sample Seed Data

The Product Service comes pre-seeded with sample data:

| ID | Name | Category | Price | Stock |
|----|------|----------|-------|-------|
| 1 | Laptop Pro | Electronics | $1,299.99 | 50 |
| 2 | Wireless Mouse | Electronics | $29.99 | 200 |
| 3 | Coffee Maker | Home & Kitchen | $79.99 | 75 |

---

## 📚 Key Concepts Covered

- ✅ **Microservices Architecture** — Independent, loosely coupled services
- ✅ **API Gateway Pattern** — Single entry point with Ocelot routing
- ✅ **Repository Pattern** — Clean separation of data access logic
- ✅ **DTO Pattern** — Data Transfer Objects for API request/response
- ✅ **Entity Framework Core** — Code-first approach with Fluent API
- ✅ **PostgreSQL Integration** — Relational database with Npgsql provider
- ✅ **Message-Based Communication** — MassTransit with RabbitMQ
- ✅ **Resilience Policies** — Polly for fault tolerance
- ✅ **Health Checks** — Built-in health monitoring endpoints
- ✅ **Structured Logging** — Serilog for observability
- ✅ **Swagger/OpenAPI** — Auto-generated API documentation
- ✅ **Dependency Injection** — Built-in .NET DI container

---

## 👨‍💻 Author

**Vivek Rajpoot**

- GitHub: [@VivekRajpoot01](https://github.com/VivekRajpoot01)

---

<div align="center">

**⭐ Part of the [dot-net-practice](https://github.com/VivekRajpoot01/dot-net-practice) learning repository ⭐**

*Learning Microservices Architecture — one service at a time! 🚀*

</div>