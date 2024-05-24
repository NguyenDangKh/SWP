using DIAMOND.Models;
using Microsoft.AspNetCore.Mvc;

namespace DIAMOND.Controllers
{
    public class ProductsController : Controller
    {

        private static List<Product> _products = new List<Product>
    {
        new Product { Id = 1, Name = "Product 1", Description = "Description 1", OldPrice = 600, NewPrice = 400, ImageUrl = "/image/earrings1/1-1.png" },
        new Product { Id = 2, Name = "Product 2", Description = "Description 2", OldPrice = 600, NewPrice = 400, ImageUrl = "/image/earrings2/2-1.png" },
        new Product { Id = 3, Name = "Product 3", Description = "Description 3", OldPrice = 600, NewPrice = 400, ImageUrl = "/image/ring1/1-1.png" },
        new Product { Id = 4, Name = "Product 4", Description = "Description 4", OldPrice = 600, NewPrice = 400, ImageUrl = "/image/ring2/2-1.png" }
    };

        public IActionResult Index()
        {

            return View(_products);
        }

        public ActionResult Detail(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        public IActionResult NecklaceView()
        {
            return View();
        }

        public IActionResult RingView()
        {
            return View();
        }

        public IActionResult EarringsView()
        {
            return View();
        }

        public IActionResult RingDetailView()
        {
            return View();
        }
        public IActionResult Feedback()
        {
            return View();
        }
    }
}
