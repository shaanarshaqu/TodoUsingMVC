using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TodoUsingMVC.Models;
using TodoUsingMVC.Services;

namespace TodoUsingMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITodoService todoService;

        public HomeController(ITodoService todoService)
        {
            this.todoService = todoService;
        }

        public async Task<IActionResult> Home()
        {
            try
            {
                return View(await todoService.ListAllTodos());
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        

        /*        public IActionResult Privacy()
                {
                    return View();
                }
                public IActionResult Test()
                {
                    return View();
                }*/

        /*     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
             public IActionResult Error()
             {
                 return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
             }*/
    }
}
