//using Microsoft.AspNetCore.Mvc;

namespace UtilityLibraries;

   // [Route("[controller]/[action]")]
   // [ApiController]
    public static class StringLibrary
    {  
        public static string Add(decimal number1 = 5, decimal number2 = 2)
        {
            return $"Hello Reader.\nThe Addition of {number1} and {number2} is = {number1 + number2}";
        }  
      
         public static string Subtract(decimal number1 = 5, decimal number2 = 2)
        {
            return $"Hello Reader.\nThe Subtraction of {number1} and {number2} is = {number1 - number2}";
        }   
       
        public static string Multiply(decimal number1 = 5, decimal number2 = 2)
        {
            return $"Hello Reader.\nThe Multiplication of {number1} and {number2} is = {number1 * number2}";
        } 
       
        public static string Divide(decimal number1 = 5, decimal number2 = 2)
        {
            if( number2 != 0) 
            {
                return $"Hello Reader.\nThe Division of {number1} and {number2} is = {number1 / number2}";
            }
            else
            {
                return $"can not divided by 0";
            }

        } 
       
         public static string Modulo(decimal number1 = 5, decimal number2 = 2)
        {
            return $"Hello Reader.\nThe Remainder of {number1} and {number2} is = {number1 % number2}";
        }   


       

    }

