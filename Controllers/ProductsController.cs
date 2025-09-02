using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsApi.Models;

namespace ProductsApi.Controllers
{
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new List<Product>
        {
        new Product { Id = 1, Name = "Samsung Galaxy S23", Price = 799.99m, IsAvailable = true },
        new Product { Id = 2, Name = "Sony WH-1000XM5 Headphones", Price = 348.00m, IsAvailable = true },
        new Product { Id = 3, Name = "Dell XPS 13 Laptop", Price = 999.99m, IsAvailable = false },
        new Product { Id = 4, Name = "Apple MacBook Pro 16-inch", Price = 2499.99m, IsAvailable = true },
        new Product { Id = 5, Name = "Fitbit Charge 5", Price = 149.95m, IsAvailable = true },
        new Product { Id = 6, Name = "Nintendo Switch OLED", Price = 349.99m, IsAvailable = true },
        new Product { Id = 7, Name = "GoPro HERO11 Black", Price = 499.99m, IsAvailable = false },
        new Product { Id = 8, Name = "Sony PlayStation 5 Console", Price = 499.99m, IsAvailable = true },
        new Product { Id = 9, Name = "Apple AirPods Pro 2nd Generation", Price = 249.99m, IsAvailable = true },
        new Product { Id = 10, Name = "Canon EOS Rebel T8i DSLR Camera", Price = 849.99m, IsAvailable = true }
        };
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(products);
        }


        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

    }
}
