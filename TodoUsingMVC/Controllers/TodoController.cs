using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TodoUsingMVC.Models;
using TodoUsingMVC.Services.interfaces;

namespace TodoUsingMVC.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoService todoService;

        public TodoController(ITodoService todoService)
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

        public async Task<IActionResult> SingleTodo()
        {
            try
            {
                return View();
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
