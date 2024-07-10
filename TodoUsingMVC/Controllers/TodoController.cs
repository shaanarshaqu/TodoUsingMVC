using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TodoUsingMVC.Models;
using TodoUsingMVC.Models.DTOs;
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
                return View(new TestModel() { listoftodos = todooos, todo = new dummy() });
            }catch (Exception ex)
            {
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


        [HttpPost]
        public async Task<IActionResult> AddTodo(dummy model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int isAdded = await todoService.AddTodo(new Todo() { Title= model.Title,Id="erdrt",user_id="1" }); // Assuming todoService.AddTodo expects a single Todo object
                    return RedirectToAction("ViewAllTodo"); // Redirect to action to show all todos after adding
                }
                else
                {
                    return View(model); // Return the view with validation errors
                }
            }
            catch (Exception ex)
            {
                return View("Error", new ErrorViewModel()); // Handle any exceptions by showing an error view
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
