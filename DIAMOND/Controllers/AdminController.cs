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
<<<<<<< HEAD
        public IActionResult OrderManager() {
            return View();
=======

        public IActionResult CertificationView()
        {
            return View();
        }
>>>>>>> 81e08e6dd315f10bbc4083359296b0647b398481
    }
}
