using Microsoft.EntityFrameworkCore;
using ProductService.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ProductService.Data
{
    public class ProductDbContext: DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Description).HasMaxLength(1000);
                entity.Property(e => e.Price).HasColumnType("decimal(18,2)");
                entity.Property(e => e.CategoryName).HasMaxLength(100);

                // Add indexes for performance
                entity.HasIndex(e => e.Name);
                entity.HasIndex(e => e.CategoryId);

                // Seed some initial data
                entity.HasData(
                    new Product
                    {
                        Id = 1,
                        Name = "Laptop Pro",
                        Description = "High-performance laptop",
                        Price = 1299.99m,
                        CategoryId = 1,
                        CategoryName = "Electronics",
                        AvailableStock = 50,
                        CreatedAt = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Wireless Mouse",
                        Description = "Ergonomic wireless mouse",
                        Price = 29.99m,
                        CategoryId = 1,
                        CategoryName = "Electronics",
                        AvailableStock = 200,
                        CreatedAt = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "Coffee Maker",
                        Description = "Programmable coffee maker",
                        Price = 79.99m,
                        CategoryId = 2,
                        CategoryName = "Home & Kitchen",
                        AvailableStock = 75,
                        CreatedAt = DateTime.UtcNow
                    }
                );

            });
        }
    }

}

