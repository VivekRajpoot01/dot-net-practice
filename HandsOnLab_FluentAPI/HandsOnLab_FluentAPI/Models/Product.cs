using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnLab_FluentAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string SKU { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte[] RowVersion { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
