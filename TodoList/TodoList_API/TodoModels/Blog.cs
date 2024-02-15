namespace TodoList_API.TodoModels;
using System.ComponentModel.DataAnnotations;
using System.Web;
public class Blog{
    public int BlogId { get; set; }
   public DateTime PublishDate { get; set; } = DateTime.Now;
    public string? Name { get; set; }
    [Url]
    public Uri? Uri { get; set; }
}