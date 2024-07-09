using Microsoft.AspNetCore.Mvc;
using TodoUsingMVC.Models.DTOs;
using TodoUsingMVC.Services.interfaces;

namespace TodoUsingMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginUser(LoginDto user)
        {
            try
            {
                bool IsLoggedIn = userService.LoginUser(user);
                return IsLoggedIn ? RedirectToAction("ViewAllTodo", "Todo") : View("Login");
            }
            catch (Exception ex)
            {
                return View("Login");
            }
        }


    }
}
