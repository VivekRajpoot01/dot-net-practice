using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
//using Microsoft.OpenApi.Models;
using OrderService.Data;
using OrderService.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Order Service API",
        Version = "v1",
        Description = "Microservice for order management"
    });
});

// Configure PostgreSQL
builder.Services.AddDbContext<OrderDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("OrderDatabase")));

// Configure HTTP client for product service
builder.Services.AddHttpClient<IProductServiceClient, ProductServiceClient>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["ServiceUrls:ProductService"]
        ?? "http://localhost:5001");
});

// Add health checks
builder.Services.AddHealthChecks();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Ensure database is created
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<OrderDbContext>();
    dbContext.Database.EnsureCreated();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapHealthChecks("/health");

app.Run();