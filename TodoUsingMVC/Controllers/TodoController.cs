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

        public async Task<IActionResult> ViewAllTodo()
        {
            try
            {
                List<Todo> todooos = await todoService.ListAllTodos();
                return View(todooos);
            }catch (Exception ex)
            {
                return View(new List<Todo>());
                return View("Error",new ErrorViewModel { RequestId="sdfs"});
            }
        }

        public async Task<IActionResult> TodoById(string id)
        {
            try
            {
                return View(await todoService.TodoSingle(id));
            }catch (Exception ex)
            {
                return View("Error", new ErrorViewModel { RequestId = "sdfs" });
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
