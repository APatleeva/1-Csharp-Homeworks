using System;
/*
    Problem 2. Float or Double?

    Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
    34.567839023, 12.345, 8923.1234857, 3456.091?
    Write a program to assign the numbers in variables and print them to ensure no precision is lost.
 */

namespace _02_FloatorDouble
{
    class FloatorDouble
    {
        static void Main()
        {            
            double vardouble=34.567839023; 
            float varfloat = 12.345f;
            Console.WriteLine("Variable of type double (64-bit, 16 digit precision): {0}; \nVariable of type float (32-bit, 7 digit precision): {1};", vardouble, varfloat);            
            Console.WriteLine("Variable of type double (64-bit, 16 digit precision): {0}; \nVariable of type float (32-bit, 7 digit precision): {1}", vardouble = 8923.1234857, varfloat = 3456.091f);
        }
    }  
}
