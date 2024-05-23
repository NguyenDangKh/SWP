using Microsoft.AspNetCore.Mvc;

namespace DIAMOND.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Order()
        {
            return View();
        }
        public IActionResult warranty() 
        {
            return View();
        }
        public IActionResult warranty_detail() {
            return View();
        }
    }
}
