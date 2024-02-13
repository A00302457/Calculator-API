using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.ConfigureServices(services =>
                {
                    // Configure services here
                    services.AddDbContext<TodoListDbContext>(options =>
                        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

                    services.AddScoped<DbSet<ToDoItem>, DbSet<ToDoItem>>(provider =>
                        provider.GetService<TodoListDbContext>().Set<ToDoItem>());
                });
                  // Register ToDoItem class to the DataContext
                services.AddScoped<DbSet<YourNamespace.ToDoItem>, DbSet<YourNamespace.ToDoItem>>(provider =>
                    provider.GetService<TodoListDbContext>().Set<YourNamespace.ToDoItem>());

                webBuilder.Configure(app =>
                {
                    // Configure middleware and endpoints here
                    app.UseRouting();
                    app.UseEndpoints(endpoints =>
                    {
                        endpoints.MapControllers();
                    });
                });
            });
}
