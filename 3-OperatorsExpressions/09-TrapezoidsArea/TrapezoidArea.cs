using System;
/* Problem 9. Trapezoids

    Write an expression that calculates trapezoid's area by given sides a and b and height h.

Examples:
a 	b 	h 	area
5 	7 	12 	72
2 	1 	33 	49.5
8.5 	4.3 	2.7 	17.28
100 	200 	300 	45000
0.222 	0.333 	0.555 	0.1540125
 */
class TrapezoidArea
{
    static void Main()
    {
        do
        {
            Console.WriteLine("Trapezoid side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Trapezoid side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Trapezoid height h: ");
            double h = double.Parse(Console.ReadLine());
            double area=h*(a+b)/2;
            Console.WriteLine("Calculated trapezoid's area by given sides a and b and height h: {0}",area);            
            Console.WriteLine("Press Esc to exit or any other key to continue:");
        }
        while (Console.ReadKey(true).Key != ConsoleKey.Escape);

    }
}