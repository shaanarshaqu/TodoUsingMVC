using Microsoft.EntityFrameworkCore;
using TodoUsingMVC.Data;
using TodoUsingMVC.Models;
using TodoUsingMVC.Services.interfaces;

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
                return await todoContext.Todos.FromSqlRaw("select * from TodoTb").ToListAsync();
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Todo> TodoSingle()
        {
            try
            {
                return await todoContext.Todos.FromSqlRaw("select * from TodoTb").FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<int> AddTodo(Todo todo)
        {
            await todoContext.AddAsync(todo);
            return await todoContext.SaveChangesAsync();
        }
    }
}
