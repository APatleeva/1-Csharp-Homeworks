using System;
/* Problem 3. Divide by 7 and 5

    Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

Examples:
n 	Divided by 7 and 5?
3 	false
0 	false
5 	false
7 	false
35 	true
140 true
 */

class Divideby
{
    static void Main()
    {      
        do
        {
            Console.WriteLine("Input integer number: ");
            int intNumber = int.Parse(Console.ReadLine());
            bool isDivide5 = intNumber % 5 == 0 ? true : false;
            bool isDivide7 = intNumber % 7 == 0 ? true : false;            
            Console.WriteLine("The number can be divided by 7 and 5: {0}", isDivide5 && isDivide7);
            Console.WriteLine("Press Esc to exit or any other key to continue:");
        }
        while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
