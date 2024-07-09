using TodoUsingMVC.Models;

namespace TodoUsingMVC.Services.interfaces
{
    public interface ITodoService
    {
        Task<List<Todo>> ListAllTodos();
        Task<Todo> TodoSingle(string id);
    }
}
