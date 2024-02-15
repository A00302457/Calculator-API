namespace TodoListModels;
using Microsoft.AspNetCore.Mvc;


    public class ToDoItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? CompletedDate { get; set; }
    }
