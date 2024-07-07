using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TodoUsingMVC.Models;

namespace TodoUsingMVC.Data
{
    public class TodoContext:DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>()
                .HasOne(t => t.user)
                .WithMany(u => u.todos)
                .HasForeignKey(t => t.user_id);
            modelBuilder.Entity<User>()
                .HasData(
                new User { Id="1",UserName="Jack",Email="jack123@gmail.com",Password="12345678"}
                );
                
            modelBuilder.Entity<Todo>()
                .HasData(
                new Todo { Id="1",Title="watch movie",user_id="1"},
                new Todo { Id = "2", Title = "play games", user_id = "1"},
                new Todo { Id = "3", Title = "eat food", user_id = "1"}
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
