using System;
using System.Threading;
using System.Globalization;

/* Problem 4. Number Comparer

    Write a program that gets two numbers from the console and prints the greater of them.
    Try to implement this without if statements.

Examples:
a 	b 	greater
5 	6 	6
10 	5 	10
0 	0 	0
-5 	-2 	-2
1.5 	1.6 	1.6
 */

class GreaterNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Input first number: "); 
        string firstStr = Console.ReadLine();
        float firstNumber;
        if (float.TryParse(firstStr.Replace(',', '.'), out firstNumber))
        {
            float secondNumber;
            Console.Write("Input second number: ");
            string secondStr = Console.ReadLine();
            if (float.TryParse(secondStr.Replace(',', '.'), out secondNumber))
            {
                Console.WriteLine("Greater number = {0}",firstNumber>secondNumber? firstNumber:secondNumber);
            }
            else Console.WriteLine("Not a valid number");
        }
        else Console.WriteLine("Not a valid number");
    }
}
