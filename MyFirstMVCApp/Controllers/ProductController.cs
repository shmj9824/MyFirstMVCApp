using Microsoft.AspNetCore.Mvc;
using MyFirstMVCApp.Models;

namespace MyFirstMVCApp.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            //return Content("Product Controller Index called");
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "iPhone", Price = 25000 },
                new Product { Id = 2, Name = "Android Phone", Price = 15000 },
                new Product { Id = 3, Name = "Windows Phone", Price = 5000 }
            }
            ;

            return View(products);
        }
    }
}
