using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Mvc;

namespace DIAMOND.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task Login()
        {
            await HttpContext.ChallengeAsync(GoogleDefaults.AuthenticationScheme, new AuthenticationProperties
            {
                RedirectUri = Url.Action("GoogleRespone")
            });
        }
        public async Task<IActionResult> GoogleRespone()
        {
            var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            var claims = result.Principal.Identities.FirstOrDefault().Claims.Select(claim => new
            {
                claim.Issuer,
                claim.OriginalIssuer,
                claim.Type,
                claim.Value
            });
            // return Json(claims);
            return RedirectToAction("Home", "Home", new { area = "" });
        }

        [Route("Login/Logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Home", "Home", new { area = "" });
        }
		[HttpPost]
		public IActionResult Login(string username, string password)
		{
			// Kiểm tra thông tin đăng nhập
			if (username == "admin" && password == "admin")
			{
				// Thực hiện đăng nhập thành công
				// Điều hướng đến trang admin hoặc trang khác tùy ý của bạn
				return RedirectToAction("DashBoard", "Admin");
			}
			else
			{
				// Thông báo lỗi đăng nhập không thành công
				ViewBag.Error = "Invalid username or password";
				return View("Index");
			}
		}
		public IActionResult Admin()
		{
			return RedirectToAction("Home", "Admin", new { area = "" });
		}


	}
}

