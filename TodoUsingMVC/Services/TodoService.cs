using Microsoft.EntityFrameworkCore;
using TodoUsingMVC.Data;
using TodoUsingMVC.Models;

namespace TodoUsingMVC.Services
{
    public class TodoService:ITodoService
    {
        private readonly TodoContext todoContext;
        public TodoService(TodoContext todoContext) 
        {
            this.todoContext = todoContext;
        }


        public async Task<List<Todo>> ListAllTodos()
        {
            try
            {
                return await todoContext.TodoTb.FromSqlRaw("select * from TodoTb").ToListAsync();
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
