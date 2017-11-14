using Microsoft.EntityFrameworkCore;

namespace TodoApi.models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
            
        }
        
        public DbSet<TodoItem> TodoItems { get; private set;}
    }
}