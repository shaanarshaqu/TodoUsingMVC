﻿using Microsoft.EntityFrameworkCore;
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
                return await todoContext.Todos.FromSqlRaw($"select * from Todos where Id = {id}").FirstOrDefaultAsync();
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
