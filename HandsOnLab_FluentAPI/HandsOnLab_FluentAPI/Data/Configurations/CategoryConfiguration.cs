using HandsOnLab_FluentAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnLab_FluentAPI.Data.Configurations
{
    public class CategoryConfiguration: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(e => e.CategoryId);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Description)
                .HasMaxLength(500);

            builder.Property(e => e.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            builder.Property(e => e.IsActive)
                .HasDefaultValue(true);

            builder.HasIndex(e => e.Name)
                .IsUnique()
                .HasDatabaseName("IX_Categories_Name");
        }

    }
}
