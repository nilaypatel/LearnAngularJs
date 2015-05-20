using System.Web.Mvc;
using MvcApplication.Web.Models;

namespace MvcApplication.Web.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            var products = new[]
            {
                new Product{Id= 1, Name = "Product 1", Price = 10.25m, Description = "Product 1 Description"},
                new Product{Id= 2, Name = "Product 2", Price = 11.5m, Description = "Product 2 Description"},
                new Product{Id= 3, Name = "Product 3", Price = 12.75m, Description = "Product 3 Description"}
            };

            return View(products);
        }

    }
}
