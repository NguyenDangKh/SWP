using Microsoft.AspNetCore.Mvc;

namespace DIAMOND.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult BlogView()
		{
			return View();
		}
	}
}
