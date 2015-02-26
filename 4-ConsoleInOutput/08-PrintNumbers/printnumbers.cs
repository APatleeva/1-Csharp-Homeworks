using System;
/* Problem 8. Numbers from 1 to n

    Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

Note: You may need to use a for-loop.

Examples:
input 	output
3 	1
	2
	3
5 	1
	2
	3
	4
	5
1 	1
 */
namespace _08_PrintNumbers
{
    class PrintNumbers
    {
        static void Main()
        {
            Console.Write("Input length of sequence: ");
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                for (int i = 1; i <= number; i++)
                {                    
                    Console.WriteLine(i);
                }
            }
            else Console.WriteLine("Not a valid number");    
        }
    }
}
