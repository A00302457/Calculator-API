namespace TodoListTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoListAPI;
[TestClass]
public class UnitTest1
{
    [TestClass]
public class TodoItemTests
{
    [TestMethod]
    public void TodoItem_SetProperties_ShouldSetCorrectly()
    {
        // Arrange
        var todoItem = new TodoItem();

        // Act
        todoItem.Id = 1;
        todoItem.Description = "Test ToDo";
        todoItem.CompletedDate = DateTime.Now;

        // Assert
        Assert.AreEqual(1, todoItem.Id);
        Assert.AreEqual("Test ToDo", todoItem.Description);
        Assert.IsNotNull(todoItem.CompletedDate);
    }

   [TestMethod]
    public void TodoItem_Id_DefaultValue_ShouldBeZero()
    {
        // Arrange
        var todoItem = new TodoItem();

        // Assert
        Assert.AreEqual(0, todoItem.Id);
    }  
    [TestMethod]
    public void TodoItem_Description_DefaultValue_ShouldBeNull()
    {
        // Arrange
        var todoItem = new TodoItem();

        // Assert
        Assert.IsNull(todoItem.Description);
    }  


   
    [TestMethod]
    public void TodoItem_CompletedDate_DefaultValue_ShouldBeNull()
    {
        // Arrange
        var todoItem = new TodoItem();

        // Assert
        Assert.IsNull(todoItem.CompletedDate);
    }

}
}