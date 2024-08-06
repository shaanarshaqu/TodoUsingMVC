using Microsoft.Data.SqlClient;
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
                return await todoContext.Todos.FromSqlRaw("select * from Todos").ToListAsync();
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Todo> TodoSingle(string id)
        {
            try
            {
                return await todoContext.Todos.FromSqlRaw("SELECT * FROM Todos WHERE Id = @id", new SqlParameter("@id", id)).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<int> AddTodo(Todo todo)
        {
            try
            {
                await todoContext.AddAsync(todo);
                return await todoContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
