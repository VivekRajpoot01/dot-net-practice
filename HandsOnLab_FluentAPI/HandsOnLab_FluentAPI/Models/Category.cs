using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnLab_FluentAPI.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
