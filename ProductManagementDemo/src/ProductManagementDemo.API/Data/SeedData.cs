using ProductManagementDemo.API.Entities;

namespace ProductManagementDemo.API.Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(AppDbContext context)
        {
            if (context.Products.Any()) return;

            var category = new Category { Name = "Electronics" };

            context.Categories.Add(category);

            context.Products.Add(new Product
            {
                Name = "iPhone 15",
                Description = "Apple smartphone",
                Price = 999,
                SKU = "IPHONE15",
                Category = category,
                CreatedAt = DateTime.UtcNow,
                ImageUrl = "https://example.com/iphone.jpg"
            });

            await context.SaveChangesAsync();
        }
    }
}
