using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class ProductController : Controller
    {

        static List<Product> products = new()
        {
            new Product() { Id = 1, Name = "Iphone X", Category = "Electronics", Price = 750 },
            new Product() { Id = 2, Name = "Samsung S22", Category = "Electronics", Price = 650 },
            new Product() { Id = 3, Name = "Audi A4", Category = "Car", Price = 24600 },
            new Product() { Id = 4, Name = "Nike T-Shirt", Category = "Clothes", Price = 50 },
            new Product() { Id = 5, Name = "Air Jordan pants", Category = "Clothes", Price = 150 }
        };
        
        public  ProductController()
        {
        }
        public IActionResult Index()
        {

            return View(products);
        }
        public IActionResult Delete(int id)
        {
            var item = products.FirstOrDefault(x => x.Id == id);
            if (item == null)
                return NotFound();

            products.Remove(item);
            return RedirectToAction("Index");

        }
        public IActionResult Details(int id)
        {
            var item = products.FirstOrDefault((x) => x.Id == id);
            if (item == null)
                return NotFound();
            return View(item);
        }
    }
}
