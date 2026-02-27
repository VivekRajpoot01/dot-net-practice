using Microsoft.AspNetCore.Mvc;
using MvcCoreWebAppDemo.Models;
using System.Text.Json;

namespace MvcCoreWebAppDemo.Controllers
{
    public class CartController : Controller
    {
        private const string CartSessionKey = "Cart";

        public IActionResult AddToCart(int id)
        {
            var product = ProductController.products.FirstOrDefault(p => p.Id == id);

            var cart = GetCart();

            var existingItem = cart.FirstOrDefault(c => c.Product.Id == id);

            if (existingItem != null)
                existingItem.Quantity++;
            else
                cart.Add(new CartItem { Product = product, Quantity = 1 });

            SaveCart(cart);

            return RedirectToAction("Index", "Product");
        }

        public IActionResult Index()
        {
            var cart = GetCart();
            return View(cart);
        }

        private List<CartItem> GetCart()
        {
            var sessionData = HttpContext.Session.GetString(CartSessionKey);
            if (sessionData == null)
                return new List<CartItem>();

            return JsonSerializer.Deserialize<List<CartItem>>(sessionData);
        }

        private void SaveCart(List<CartItem> cart)
        {
            HttpContext.Session.SetString(CartSessionKey, JsonSerializer.Serialize(cart));
            HttpContext.Session.SetInt32("CartCount", cart.Sum(c => c.Quantity));
        }
    }
}
