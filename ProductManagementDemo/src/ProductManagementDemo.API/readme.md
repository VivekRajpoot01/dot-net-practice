# ProductManagementDemo.API

A simple **ASP.NET Core Web API (.NET 8)** demo project for managing products.  
It uses:

- **Entity Framework Core (InMemory provider)** for persistence (no external database required)
- **Swagger/OpenAPI** for API documentation and testing
- **AutoMapper** for DTO ↔ entity mapping
- Basic **API versioning in routes** (`/api/v1/...`)
- A **seed step on startup** to preload sample data into the in-memory database

> Project path: `ProductManagementDemo/src/ProductManagementDemo.API`

---

## Tech Stack

- **.NET**: `net8.0`
- **ASP.NET Core Web API**
- **EF Core InMemory**: `Microsoft.EntityFrameworkCore.InMemory`
- **Swagger**: `Swashbuckle.AspNetCore`
- **AutoMapper**
- **FluentValidation.AspNetCore** (package referenced)
- **API Versioning packages** (package referenced)

Packages are defined in `ProductManagementDemo.API.csproj`.

---

## Project Structure (high level)

```
ProductManagementDemo.API
├─ Controllers/
│  └─ ProductsController.cs
├─ DTOs/
│  ├─ CategoryDTOs.cs
│  ├─ InventoryDTOs.cs
│  └─ ProductDTOs.cs
├─ Data/
├─ Entities/
├─ Mapping/
├─ Services/
├─ Program.cs
├─ appsettings.json
├─ appsettings.Development.json
└─ ProductManagementDemo.API.http
```

> Note: This README describes the API based on the available code in `Program.cs`, the `.csproj`, the `ProductsController`, and DTO files.

---

## How it runs (startup pipeline)

The application is configured in `Program.cs` with the following key steps:

1. Adds MVC controllers:
   - `builder.Services.AddControllers();`

2. Registers EF Core in-memory DB:
   - `UseInMemoryDatabase("ProductDB")`

3. Registers AutoMapper:
   - Mapping profile type: `MappingProfile`

4. Registers Product service in DI:
   - `IProductService` → `ProductService`

5. Enables Swagger:
   - `AddEndpointsApiExplorer()`
   - `AddSwaggerGen()`

6. Seeds data on startup:
   - Creates a scope and calls `SeedData.InitializeAsync(db)`

7. Exposes Swagger UI and maps controllers:
   - `app.UseSwagger();`
   - `app.UseSwaggerUI();`
   - `app.MapControllers();`

---

## Configuration

### `appsettings.json`
Contains logging defaults and `AllowedHosts`:

- Logging: `Information` by default
- ASP.NET Core logs: `Warning`
- AllowedHosts: `*`

### `appsettings.Development.json`
Contains logging configuration for development.

Because the database is **in-memory**, there is **no connection string** required.

---

## API Endpoints

All endpoints are under:

- Base route: `/api/v1/products`

Controller: `ProductsController`

### 1) Get all products (with filtering + pagination)

- **GET** `/api/v1/products`
- Query params:
  - `pageNumber` (default: `1`)
  - `pageSize` (default: `10`)
  - Filter object is read from query using: `ProductFilterDto` (from `DTOs/ProductDTOs.cs`)

Example:
```http
GET /api/v1/products?pageNumber=1&pageSize=10
```

### 2) Get product by id

- **GET** `/api/v1/products/{id}`

Example:
```http
GET /api/v1/products/1
```

### 3) Create product

- **POST** `/api/v1/products`
- Body: `CreateProductDto`

Returns:
- `201 Created`
- `Location` header points to `GET /api/v1/products/{id}` via `CreatedAtAction(...)`

Example:
```http
POST /api/v1/products
Content-Type: application/json

{
  "name": "Keyboard",
  "price": 49.99,
  "categoryId": 1
}
```

### 4) Update product

- **PUT** `/api/v1/products/{id}`
- Body: `UpdateProductDto`

Example:
```http
PUT /api/v1/products/1
Content-Type: application/json

{
  "name": "Mechanical Keyboard",
  "price": 69.99
}
```

### 5) Delete product

- **DELETE** `/api/v1/products/{id}`

Behavior:
- Returns `404 Not Found` if delete returns `false`
- Otherwise returns `204 No Content`

Example:
```http
DELETE /api/v1/products/1
```

---

## DTOs

DTOs live in `DTOs/`:

- `CategoryDTOs.cs`  
- `InventoryDTOs.cs`  
- `ProductDTOs.cs` (contains multiple DTO types, including filtering & create/update payloads)

These DTOs are used by the controller and (typically) by the service layer.

---

## Running the project

From the repository root (or from the API folder):

```bash
dotnet restore
dotnet run --project ProductManagementDemo/src/ProductManagementDemo.API/ProductManagementDemo.API.csproj
```

Then open Swagger in your browser (typical default):

- `https://localhost:<port>/swagger`
- or `http://localhost:<port>/swagger`

(The exact port depends on your local launch settings / dev environment.)

---

## Testing quickly

### Swagger UI
Use Swagger to try the endpoints without additional tools.

### HTTP file
There is a `ProductManagementDemo.API.http` file intended for quickly calling the API from an IDE (like Visual Studio / Rider).

---

## Notes / Limitations

- Data is stored in an **in-memory database**, so it resets every time the app restarts.
- Seed data runs at startup (`SeedData.InitializeAsync`), so the API should have initial data available immediately after launch.
- Authentication/authorization is not shown in the available code excerpts (assume this is a demo API).

---

