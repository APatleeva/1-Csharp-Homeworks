using System;
using System.Threading;
using System.Globalization;
/* Problem 7. Sum of 5 Numbers

    Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

Examples:
numbers 	sum
1 2 3 4 5 	15
10 10 10 10 10 	50
1.5 3.14 8.2 -1 0 	11.84
 */

class Sumof5Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 
        Console.Write("Enter 5 numbers, separated by a space: ");
        string allNumbers = Console.ReadLine();
        allNumbers = allNumbers.Replace(',', '.');
        string[] splitted = allNumbers.Split(' ');
        double sum=0;
        foreach (string s in splitted)
        {
            sum +=Convert.ToDouble(s);            
        }
        allNumbers = allNumbers.Replace(' ','+');
        Console.WriteLine("{0} = {1}",allNumbers, sum);
    }
}

