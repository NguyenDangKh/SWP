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
        public IActionResult Warranty() 
        {
            return View();
        }
        public IActionResult Warranty_detail() {
            return View();
        }
    }
}
