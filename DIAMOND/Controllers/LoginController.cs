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

		public async Task Login(string returnUrl = null)
		{
			var redirectUrl = Url.Action("GoogleResponse", "Login", new { returnUrl });
			await HttpContext.ChallengeAsync(GoogleDefaults.AuthenticationScheme, new AuthenticationProperties
			{
				RedirectUri = redirectUrl
			});
		}

		public async Task<IActionResult> GoogleResponse(string returnUrl = null)
		{
			var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

			var claims = result.Principal.Identities.FirstOrDefault().Claims.Select(claim => new
			{
				claim.Issuer,
				claim.OriginalIssuer,
				claim.Type,
				claim.Value
			});

			// Redirect to returnUrl if provided, otherwise default to home page
			return Redirect(string.IsNullOrEmpty(returnUrl) ? Url.Action("Home", "Home") : returnUrl);
		}

		[Route("Login/Logout")]
		public async Task<IActionResult> Logout()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			return RedirectToAction("Home", "Home", new { area = "" });
		}

		[HttpPost]
		public IActionResult Login(string username, string password, string returnUrl = null)
		{
			// Kiểm tra thông tin đăng nhập
			if (username == "admin" && password == "admin")
			{
				// Thực hiện đăng nhập thành công
				// Điều hướng đến trang admin hoặc trang khác tùy ý của bạn
				return Redirect(string.IsNullOrEmpty(returnUrl) ? Url.Action("DashBoard", "Admin") : returnUrl);
			}
			else
			{
				// Thông báo lỗi đăng nhập không thành công
				ViewBag.Error = "Invalid username or password";
				ViewBag.ReturnUrl = returnUrl;
				return View("Index");
			}
		}

		public IActionResult Admin()
		{
			return RedirectToAction("Home", "Admin", new { area = "" });
		}
	}
}
