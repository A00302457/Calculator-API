using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
 using System.Linq;
namespace TodoList.Models;

 public class Class1
{
    public void ConfigureServices(IServiceCollection services)
{
    // Other services...

    services.AddDbContext<TodoListDbContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

    // Register ToDoItem class to the DataContext
    services.AddScoped<DbSet<ToDoItem>, DbSet<ToDoItem>>(provider => provider.GetService<TodoListDbContext>().Set<ToDoItem>());
}


 }


