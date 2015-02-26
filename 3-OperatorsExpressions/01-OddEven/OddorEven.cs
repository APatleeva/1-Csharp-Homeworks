using System;
/* Problem 1. Odd or Even Integers

    Write an expression that checks if given integer is odd or even.

*/

class OddorEven
{
    static void Main()
    {
        checked
        {
            Console.WriteLine("Input number of type integer: ");
            int intNumber = int.Parse(Console.ReadLine());
            Console.WriteLine((intNumber % 2 == 0) ? "Even" : "Odd");
        }
    }
}