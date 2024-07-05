using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TodoUsingMVC.Models;

namespace TodoUsingMVC.Data
{
    public class TodoContext:DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<Todo> TodoTb { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>()
                .HasData(
                new Todo { Id="1",Title="watch movie"},
                new Todo { Id = "2", Title = "play games" },
                new Todo { Id = "3", Title = "eat food" }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
