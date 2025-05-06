using Microsoft.AspNetCore.Mvc;

namespace GawaPH.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult CreateAccount()
        {
            return View();
        }
    }
}
