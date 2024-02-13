using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{
    private readonly TodoListDbContext _context;

    public TodoController(TodoListDbContext context)
    {
        _context = context;
    }

    // GET: api/Todo
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ToDoItem>>> GetToDoItems()
    {
        var todoItems = await _context.ToDoItems
            .Where(item => item.CompletedDate == null)
            .ToListAsync();

        return Ok(todoItems);
    }
    [HttpGet("{id}")]
public async Task<ActionResult<ToDoItem>> GetToDoItemById(int id)
{
    var todoItem = await _context.ToDoItems.FindAsync(id);

    if (todoItem == null)
        return NotFound();

    return Ok(todoItem);
}
[HttpPost]
public async Task<ActionResult<ToDoItem>> CreateToDoItem(ToDoItem newItem)
{
    _context.ToDoItems.Add(newItem);
    await _context.SaveChangesAsync();

    return CreatedAtAction(nameof(GetToDoItemById), new { id = newItem.Id }, newItem);
}
[HttpPost("{id}/complete")]
public async Task<ActionResult<ToDoItem>> MarkToDoItemAsCompleted(int id)
{
    var todoItem = await _context.ToDoItems.FindAsync(id);

    if (todoItem == null)
        return NotFound();

    todoItem.CompletedDate = DateTime.Now;
    await _context.SaveChangesAsync();

    return Ok(todoItem);
}

}
