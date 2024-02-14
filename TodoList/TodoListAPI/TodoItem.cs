using Microsoft.AspNetCore.Mvc;
namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
     public class TodoItem : Controller
     {
        //Create a Get request that takes no arguments and returns all ToDoItems that have no CompletedDate set.
     }
}