using System;
using System.Threading;
using System.Globalization;
/*Problem 1. Sum of 3 Numbers

    Write a program that reads 3 real numbers from the console and prints their sum.

Examples:
a 	b 	c 	sum
3 	4 	11 	18
-2 	0 	3 	1
5.5 	4.5 	20.1 	30.1
 */


class SumNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 
        Console.Write("Input first real number: ");
        float firstNumber;
        if (float.TryParse(Console.ReadLine(), out firstNumber))
        {            
            float secondNumber;
            Console.Write("Input second real number: ");
            if (float.TryParse(Console.ReadLine(), out secondNumber))
            {
                float thirdNumber;
                Console.Write("Input third real number: ");
                if (float.TryParse(Console.ReadLine(), out thirdNumber))
                {
                    Console.WriteLine("Sum of numbers: {0:F3}",firstNumber+secondNumber+thirdNumber);
                }
                else Console.WriteLine("Not a valid number");   
            }
            else  Console.WriteLine("Not a valid number");             
        }
        else Console.WriteLine("Not a valid number");
    }
}
// if (Console.KeyAvailable) {} 
// string.Format("ani string {0:F2}", numericValue);
/*  using System.Threading;
    using System.Globalization
    Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; */
/*  using System.Text;
   Console.OutputEncoding = Encoding.UTF8;
 * int a=new int(); 
 */
 