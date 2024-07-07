using Microsoft.AspNetCore.Mvc;

namespace TodoUsingMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
