using TodoUsingMVC.Models;

namespace TodoUsingMVC.Services
{
    public interface ITodoService
    {
        Task<List<Todo>> ListAllTodos();
    }
}
