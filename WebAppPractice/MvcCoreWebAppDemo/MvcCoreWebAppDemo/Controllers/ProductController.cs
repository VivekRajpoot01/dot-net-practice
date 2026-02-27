using Microsoft.AspNetCore.Mvc;
using MvcCoreWebAppDemo.Models;

namespace MvcCoreWebAppDemo.Controllers
{
    public class ProductController : Controller
    {
        public static List<Category> categories = new List<Category>
        {
            new Category{ Id = 1, Name = "Electronics"},
            new Category{ Id = 2, Name = "Groceries"},
            new Category{ Id = 3, Name = "Clothes"}
        };

        public static List<Product> products = new List<Product>
        {
            // ================= Electronics =================
            new Product{ Id=1, Name="Laptop", Price=50000, ImageUrl="https://images.pexels.com/photos/109371/pexels-photo-109371.jpeg", CategoryId=1 },
            new Product{ Id=2, Name="Smartphone", Price=20000, ImageUrl="https://images.pexels.com/photos/1092644/pexels-photo-1092644.jpeg", CategoryId=1 },
            new Product{ Id=3, Name="Headphones", Price=3000, ImageUrl="https://images.pexels.com/photos/3394650/pexels-photo-3394650.jpeg", CategoryId=1 },
            new Product{ Id=4, Name="Smart Watch", Price=7000, ImageUrl="https://images.pexels.com/photos/393047/pexels-photo-393047.jpeg", CategoryId=1 },
            new Product{ Id=5, Name="Bluetooth Speaker", Price=4500, ImageUrl="https://images.pexels.com/photos/9072408/pexels-photo-9072408.jpeg", CategoryId=1 },

            // ================= Groceries =================
            new Product{ Id=6, Name="Rice 5kg", Price=300, ImageUrl="https://images.pexels.com/photos/8108116/pexels-photo-8108116.jpeg", CategoryId=2 },
            new Product{ Id=7, Name="Wheat Flour", Price=250, ImageUrl="https://images.pexels.com/photos/6287223/pexels-photo-6287223.jpeg", CategoryId=2 },
            new Product{ Id=8, Name="Cooking Oil", Price=180, ImageUrl="https://images.pexels.com/photos/12284682/pexels-photo-12284682.jpeg", CategoryId=2 },
            new Product{ Id=9, Name="Fresh Apples", Price=120, ImageUrl="https://images.pexels.com/photos/672101/pexels-photo-672101.jpeg", CategoryId=2 },
            new Product{ Id=10, Name="Milk", Price=60, ImageUrl="https://images.pexels.com/photos/248412/pexels-photo-248412.jpeg", CategoryId=2 },

            // ================= Clothes =================
            new Product{ Id=11, Name="Casual Shirt", Price=1000, ImageUrl="https://images.pexels.com/photos/297933/pexels-photo-297933.jpeg", CategoryId=3 },
            new Product{ Id=12, Name="T-Shirt", Price=800, ImageUrl="https://images.pexels.com/photos/8532616/pexels-photo-8532616.jpeg", CategoryId=3 },
            new Product{ Id=13, Name="Jeans", Price=1500, ImageUrl="https://images.pexels.com/photos/1598507/pexels-photo-1598507.jpeg", CategoryId=3 },
            new Product{ Id=14, Name="Jacket", Price=2500, ImageUrl="https://images.pexels.com/photos/30374453/pexels-photo-30374453.jpeg", CategoryId=3 },
            new Product{ Id=15, Name="Sneakers", Price=2200, ImageUrl="https://images.pexels.com/photos/847371/pexels-photo-847371.jpeg", CategoryId=3 }
        };

        public IActionResult Index(int? categoryId)
        {
            ViewBag.Categories = categories;

            var filteredProducts = categoryId == null
                ? products
                : products.Where(p => p.CategoryId == categoryId).ToList();

            return View(filteredProducts);
        }
    }
}
