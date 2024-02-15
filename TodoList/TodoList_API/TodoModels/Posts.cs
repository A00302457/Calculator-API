using System.ComponentModel.DataAnnotations;
using System.Web;

namespace TodoList_API.TodoModels
{
    public class Post
    {
        public int BlogId { get; set; }
        [Key]
        public int Id{get;set;}
        public DateTime PublishDate { get; set; }
        public string? Name { get; set; }
        public string? Content { get; set; }
        
        
    }
}