using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class Calculator : Controller
    {
        public string Add(decimal number1 = 5, decimal number2 = 2)
        {
            return $"The Addition of {number1} and {number2} is = {number1 + number2}";
        }  
         public string Subtract(decimal number1 = 5, decimal number2 = 2)
        {
            return $"The Subtraction of {number1} and {number2} is = {number1 - number2}";
        }   

        public string Multiply(decimal number1 = 5, decimal number2 = 2)
        {
            return $"The Multiplication of {number1} and {number2} is = {number1 * number2}";
        }   

        public string Divide(decimal number1 = 5, decimal number2 = 2)
        {
            return $"The Division of {number1} and {number2} is = {number1 / number2}";
        } 
         public string Modulo(decimal number1 = 5, decimal number2 = 2)
        {
            return $"The Remainder of {number1} and {number2} is = {number1 % number2}";
        }   


        public string Get()
        {
            return "Get Method";
        }

    }
}
