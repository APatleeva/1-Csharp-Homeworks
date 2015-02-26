using System;
/* Problem 6. The Biggest of Five Numbers

    Write a program that finds the biggest of five numbers by using only five if statements.

Examples:
a 	b 	c 	d 	e 	biggest
5 	2 	2 	4 	1 	5
-2 	-22 	1 	0 	0 	1
-2 	4 	3 	2 	0 	4
0 	-2.5 	0 	5 	5 	5
-3 	-0.5 	-1.1 	-2 	-0.1 	-0.1
 */


class theBiggestof6
{
    static void Main()
    {
        do
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("d= ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("e= ");
            double e = double.Parse(Console.ReadLine());
            double biggestNumber;
            if ((a >= b) && (a >= c) && (a >= d) && (a >= e))
            {
                biggestNumber = a;
            }
            else if ((b >= a) && (b >= c) && (b >= d) && (b >= e))
            {
                biggestNumber = b;
            }
            else if ((c >= a) && (c >= b) && (c >= d) && (c >= e))
            {
                biggestNumber = c;
            }
            else if ((d >= a) && (d >= b) && (d >= c) && (d >= e))
            {
                biggestNumber = d;
            }
            else
            {
                biggestNumber = e;
            }
            Console.WriteLine("The biggest number is: {0}", biggestNumber);
            Console.WriteLine("Press Esc to exit or any other key to continue:");
        }
        while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
