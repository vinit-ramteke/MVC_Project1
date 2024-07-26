using Microsoft.AspNetCore.Mvc;

namespace WebProject1.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Login()
		{
			return View();
		}

	}
}
