// ToDoController.cs
using Microsoft.AspNetCore.Mvc;
using System.Linq;
//using TodoListAPI.Controllers;
using TodoListAPI;

[ApiController]
[Route("[controller]/[action]")]
public class TodoController : ControllerBase
{
    private readonly DatabaseContext _dbContext;

    public TodoController(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet("{id}")]
    public int GetToDoItemById(int id)
    {
        var TodoItem = _dbContext.TodoItems.FirstOrDefault(item => item.Id == id);

        if (TodoItem == null)
        {
           // return NotFound(); // Return 404 Not Found if the item is not found
        }

        return TodoItem.Id;
    }

  
    [HttpPost]
    public int CreateToDoItem (TodoItem TodoItem)
    {
        if (TodoItem == null)
        {
            // Return a value to indicate a bad request
             return -1;
        }

            _dbContext.TodoItems.Add(TodoItem);
            _dbContext.SaveChanges();

         // Return the ID of the created ToDoItem
         return TodoItem.Id;
    }
    [HttpPost("{id}/complete")]
    
    public int MarkToDoItemAsCompleted(int id)
    {
        var TodoItem = _dbContext.TodoItems.FirstOrDefault(item => item.Id == id);

        if (TodoItem == null)
        {
            return -1; // Return a value to indicate item not found
        }

        TodoItem.CompletedDate = DateTime.Now;
         _dbContext.SaveChanges();

        // Return the ID of the completed ToDoItem
         return TodoItem.Id;
    }




}
