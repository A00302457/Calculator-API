using Microsoft.AspNetCore.Mvc;
//namespace MyApp.Namespace;
//{
    
//      public class TodoItem 
//      {
//         //Create a Get request that takes no arguments and returns all ToDoItems that have no CompletedDate set.
//      }
// }



// ToDoItem.cs
namespace TodoListAPI
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? CompletedDate { get; set; }
    }
}

