using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class Calculator : Controller
    {   [HttpGet]
        public string Add(decimal number1 = 5, decimal number2 = 2)
        {
            return $"Hello Reader.\nThe Addition of {number1} and {number2} is = {number1 + number2}";
        }  
        [HttpGet]
         public string Subtract(decimal number1 = 5, decimal number2 = 2)
        {
            return $"Hello Reader.\nThe Subtraction of {number1} and {number2} is = {number1 - number2}";
        }   
        [HttpGet]
        public string Multiply(decimal number1 = 5, decimal number2 = 2)
        {
            return $"Hello Reader.\nThe Multiplication of {number1} and {number2} is = {number1 * number2}";
        } 
        [HttpGet]
        public string Divide(decimal number1 = 5, decimal number2 = 2)
        {
            return $"Hello Reader.\nThe Division of {number1} and {number2} is = {number1 / number2}";
        } 
        [HttpGet]
         public string Modulo(decimal number1 = 5, decimal number2 = 2)
        {
            return $"Hello Reader.\nThe Remainder of {number1} and {number2} is = {number1 % number2}";
        }   


        public string Get()
        {
            return "Get Method";
        }

    }
}
