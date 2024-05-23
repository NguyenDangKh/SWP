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
    }
}
