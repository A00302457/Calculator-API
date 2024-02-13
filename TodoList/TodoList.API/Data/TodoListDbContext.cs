using Microsoft.EntityFrameworkCore; 
public class TodoListDbContext : DbContext 
{ 
    public DbSet<ToDoItem> ToDoItems { get; set; } 
    public TodoListDbContext(DbContextOptions<TodoListDbContext> options) : base(options) { }
 }
