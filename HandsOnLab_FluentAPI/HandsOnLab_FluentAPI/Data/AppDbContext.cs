using Microsoft.EntityFrameworkCore;
using HandsOnLab_FluentAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnLab_FluentAPI.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FluentApiLab;Trusted_Connection=True;");
        }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Configure Category entity
        //    modelBuilder.Entity<Category>(entity =>
        //    {
        //        // Table mapping
        //        entity.ToTable("Categories");

        //        // Primary key
        //        entity.HasKey(e => e.CategoryId);

        //        // Properties
        //        entity.Property(e => e.Name)
        //            .IsRequired()
        //            .HasMaxLength(100)
        //            .HasColumnType("nvarchar(100)");

        //        entity.Property(e => e.Description)
        //            .HasMaxLength(500)
        //            .HasColumnType("nvarchar(500)");

        //        entity.Property(e => e.CreatedDate)
        //            .HasDefaultValueSql("GETDATE()")
        //            .HasColumnType("datetime2");

        //        entity.Property(e => e.IsActive)
        //            .HasDefaultValue(true);

        //        // Indexes
        //        entity.HasIndex(e => e.Name)
        //        .IsUnique()
        //            .HasDatabaseName("IX_Categories_Name");
        //    });
        //    // Configure Product entity
        //    modelBuilder.Entity<Product>(entity =>
        //    {
        //        entity.ToTable("Products");
        //        entity.HasKey(e => e.ProductId);

        //        entity.Property(e => e.Name)
        //            .IsRequired()
        //            .HasMaxLength(200);

        //        entity.Property(e => e.Description)
        //            .HasMaxLength(1000);

        //        entity.Property(e => e.Price)
        //            .HasColumnType("decimal(18,2)")
        //            .IsRequired();

        //        entity.Property(e => e.StockQuantity)
        //            .IsRequired();

        //        entity.Property(e => e.SKU)
        //            .IsRequired()
        //            .HasMaxLength(20)
        //            .HasColumnType("varchar(20)");

        //        entity.Property(e => e.CreatedAt)
        //            .HasDefaultValueSql("GETDATE()");

        //        // RowVersion for concurrency
        //        entity.Property(e => e.RowVersion)
        //            .IsRowVersion();

        //        // Indexes
        //        entity.HasIndex(e => e.SKU)
        //            .IsUnique();

        //        entity.HasIndex(e => e.Name);

        //        // Relationship
        //        entity.HasOne(e => e.Category)
        //            .WithMany(e => e.Products)
        //            .HasForeignKey(e => e.CategoryId)
        //            .OnDelete(DeleteBehavior.Restrict);
        //    });

        //    // Configure Customer entity
        //    modelBuilder.Entity<Customer>(entity =>
        //    {
        //        entity.ToTable("Customers");
        //        entity.HasKey(e => e.CustomerId);

        //        entity.Property(e => e.FirstName)
        //            .IsRequired()
        //            .HasMaxLength(50);

        //        entity.Property(e => e.LastName)
        //            .IsRequired()
        //            .HasMaxLength(50);

        //        entity.Property(e => e.Email)
        //            .IsRequired()
        //            .HasMaxLength(100);

        //        // Computed column
        //        entity.Property(e => e.FullName)
        //            .HasComputedColumnSql("[FirstName] + ' ' + [LastName]");

        //        entity.Property(e => e.Phone)
        //            .HasMaxLength(20);

        //        entity.Property(e => e.DateOfBirth)
        //            .HasColumnType("date");

        //        entity.Property(e => e.IsPremium)
        //            .HasDefaultValue(false);

        //        // Unique index on Email
        //        entity.HasIndex(e => e.Email)
        //            .IsUnique();
        //    });
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply configurations individually
            // modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            // modelBuilder.ApplyConfiguration(new ProductConfiguration());

            // OR apply all configurations from the current assembly (recommended) [citation:8]
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }


    }
}


        
    
