using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;
namespace StringLibraryTest;


[TestClass]
public class UnitTest1
{
    //.............................................Addition Functions..........................................

    [TestMethod]
     public void Add_WhenCalledWithTwoPositiveNumbers_ReturnsSum()
    {      
         
        decimal number1 = 5;
        decimal number2 = 2;
        decimal expectedSum = number1 + number2;       
        string result = StringLibrary.Add(number1, number2);       
        Assert.AreEqual($"Hello Reader.\nThe Addition of {number1} and {number2} is = {expectedSum}", result);
    }

    [TestMethod]
    public void Add_WhenCalledWithNegativeAndPositiveNumbers_ReturnsSum()
    {
        decimal number1 = 5;
        decimal number2 = -2;
        decimal expectedSum = number1 + number2;       
        string result = StringLibrary.Add(number1, number2);       
        Assert.AreEqual($"Hello Reader.\nThe Addition of {number1} and {number2} is = {expectedSum}", result);
    }

    [TestMethod]
    public void Add_WhenCalledWithTwoNegativeNumbers_ReturnsSum()
    {
        decimal number1 = -5;
        decimal number2 = -2;
        decimal expectedSum = number1 + number2;       
        string result = StringLibrary.Add(number1, number2);       
        Assert.AreEqual($"Hello Reader.\nThe Addition of {number1} and {number2} is = {expectedSum}", result);
    }

    [TestMethod]
    public void Add_WhenCalledWithZero_ReturnsOtherNumber()
    {
        decimal number1 = 5;
        decimal number2 = 0;              
        string result = StringLibrary.Add(number1, number2);       
       Assert.AreEqual($"Hello Reader.\nThe Addition of {number1} and {number2} is = {number1}", result);
    }

    [TestMethod]
    public void Add_WhenCalledWithTwoZeros_ReturnsZero()
    {
        
        decimal number1 = 0;
        decimal number2 = 0;
        string result = StringLibrary.Add(number1, number2);
        Assert.AreEqual($"Hello Reader.\nThe Addition of {number1} and {number2} is = 0", result);
    }


        //....................................Sunstraction Functions............................................
    [TestMethod]    
    public void Subtract_TwoPositiveNumbers_ReturnsDifference()
    {    
        decimal number1 = 8;
        decimal number2 = 3;
        decimal expectedDifference = number1 - number2;
        string result = StringLibrary.Subtract(number1, number2);
        Assert.AreEqual($"Hello Reader.\nThe Subtraction of {number1} and {number2} is = {expectedDifference}", result);
    }
    [TestMethod] 
    public void Subtract_ZeroFromPositiveNumber_ReturnsPositiveNumber()
    {    
         decimal number1 = 10;
         decimal number2 = 0;   
         string result = StringLibrary.Subtract(number1, number2);   
         Assert.AreEqual($"Hello Reader.\nThe Subtraction of {number1} and {number2} is = {number1}", result);
    }
    [TestMethod] 
    public void Subtract_PositiveNumberFromZero_ReturnsNegativeNumber()
    {

        decimal number1 = 0;
        decimal number2 = 7;
        string result = StringLibrary.Subtract(number1, number2); 
        Assert.AreEqual($"Hello Reader.\nThe Subtraction of {number1} and {number2} is = -{number2}", result);
    }
    [TestMethod] 
    public void Subtract_TwoNegativeNumbers_ReturnsNegativeDifference()
    {
   
        decimal number1 = -5;
        decimal number2 = -3;
        decimal expectedDifference = number1 - number2;   
        string result = StringLibrary.Subtract(number1, number2);   
        Assert.AreEqual($"Hello Reader.\nThe Subtraction of {number1} and {number2} is = {expectedDifference}", result);
    }
    [TestMethod] 
    public void Subtract_PositiveNumberFromNegativeNumber_ReturnsNegativeDifference()
    {    
        decimal number1 = -8;
        decimal number2 = 3;
        decimal expectedDifference = number1 - number2;    
        string result = StringLibrary.Subtract(number1, number2);  
        Assert.AreEqual($"Hello Reader.\nThe Subtraction of {number1} and {number2} is = {expectedDifference}", result);
    }

    //.........................................Multiplication.................................
     [TestMethod]
    public void Multiply_TwoPositiveNumbers_ReturnsProduct()
    {       
        decimal number1 = 5;
        decimal number2 = 3;
        decimal expectedProduct = number1 * number2;      
        string result = StringLibrary.Multiply(number1, number2);       
        Assert.AreEqual($"Hello Reader.\nThe Multiplication of {number1} and {number2} is = {expectedProduct}", result);
    }

    [TestMethod]
    public void Multiply_PositiveNumberByZero_ReturnsZero()
    {       
        decimal number = 10;       
        string result = StringLibrary.Multiply(number, 0);       
        Assert.AreEqual($"Hello Reader.\nThe Multiplication of {number} and 0 is = 0", result);
    }

    [TestMethod]
    public void Multiply_TwoNegativeNumbers_ReturnsProduct()
    {       
        decimal number1 = -4;
        decimal number2 = -2;
        decimal expectedProduct = number1 * number2;    
        string result = StringLibrary.Multiply(number1, number2);    
        Assert.AreEqual($"Hello Reader.\nThe Multiplication of {number1} and {number2} is = {expectedProduct}", result);
    }

    [TestMethod]
    public void Multiply_PositiveNumberByOne_ReturnsSameNumber()
    {       
        decimal number = 20;     
        string result = StringLibrary.Multiply(number, 1);      
        Assert.AreEqual($"Hello Reader.\nThe Multiplication of {number} and 1 is = {number}", result);
    }

    [TestMethod]
    public void Multiply_ZeroByAnyNumber_ReturnsZero()
    {       
        decimal number = 30;  
        string result = StringLibrary.Multiply(0, number); 
        Assert.AreEqual($"Hello Reader.\nThe Multiplication of 0 and {number} is = 0", result);
    }

    
    //.......................................Division.............................................................

    [TestMethod]
    public void Divide_TwoPositiveNumbers_ReturnsQuotientString()
    {        
        decimal number1 = 15;
        decimal number2 = 3;        
        string result = StringLibrary.Divide(number1, number2);        
        Assert.AreEqual($"Hello Reader.\nThe Division of {number1} and {number2} is = {number1 / number2}", result);
    }

    [TestMethod]
    public void Divide_PositiveNumberByOne_ReturnsSameNumberString()
    {        
        decimal number = 20;       
        string result = StringLibrary.Divide(number, 1);       
        Assert.AreEqual($"Hello Reader.\nThe Division of {number} and 1 is = {number}", result);
    }

    [TestMethod]
    public void Divide_AnyNumberByZero()
    {       
        decimal number = 30;   
        string result = StringLibrary.Divide(number, 0);
        Assert.AreEqual("can not divided by 0", result);
    }

    [TestMethod]
     public void Divide_ZeroByAnyNumber_ReturnsZeroString()
    {      
        decimal number = 40;     
        string result = StringLibrary.Divide(0, number);       
        Assert.AreEqual($"Hello Reader.\nThe Division of 0 and {number} is = 0", result);
    }
   
   [TestMethod]
    public void Divide_PositiveNumberByZero_ReturnsErrorMessage()
    {        
        decimal number = 50;      
        string result = StringLibrary.Divide(number, 0);
        Assert.AreEqual("can not divided by 0", result);
    }

}