using System;
/* 
 Problem 9. Exchange Variable Values

    Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
    Print the variable values before and after the exchange.

 */

namespace _09_ExchangeValues
{
    class ExchangeVarValues
    {
        static void Main()
        {
            int firstValue = 5;
            int secondValue = 10;            
            Console.WriteLine("Values before exchange are: firstValue = {0}, secondValue = {1}", firstValue, secondValue);
            int exchangeValue = firstValue;
            firstValue = secondValue;
            secondValue = exchangeValue;
            Console.WriteLine("Values after exchange are: firstValue = {0}, secondValue = {1}", firstValue, secondValue);
        }
    }
}
