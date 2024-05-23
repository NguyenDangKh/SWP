using Microsoft.AspNetCore.Mvc;

namespace DIAMOND.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Dashboard() 
        {
            return View();
        }

        public IActionResult AccountsManagement()
        {
            return View();
        }
        public IActionResult ProductView()
        {
            return View();
        }
    }
}
