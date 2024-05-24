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
            }
=======
        public IActionResult OrderManager()
        {
            return View();
        }

>>>>>>> d3e1c1d3a8fd1625ec7fe0b4c9ade5d11d6c05a7
        public IActionResult CertificationView()
        {
            return View();
        }

<<<<<<< HEAD


=======
>>>>>>> d3e1c1d3a8fd1625ec7fe0b4c9ade5d11d6c05a7
    }
}
