
using Microsoft.EntityFrameworkCore;
using TodoList_API;
using TodoList_API.TodoModels;
namespace TodoList_API.Data
{

    public class DataBaseContext : DbContext
    {
        public DataBaseContext( DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        public DbSet<Blog> Blogs { get; set; }
         public DbSet<Post> Posts { get; set; }
    }
}
