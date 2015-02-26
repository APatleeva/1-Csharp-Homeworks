using System;
using System.Threading;
using System.Globalization;

/* Problem 6. Quadratic Equation

    Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

Examples:
a 	b 	c 	roots
2 	5 	-3 	x1=-3; x2=0.5
-1 	3 	0 	x1=3; x2=0
-0.5 	4 	-8 	x1=x2=4
5 	2 	8 	no real roots
 */

class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;                
        Console.Write("a = ");
        string firstStr = Console.ReadLine();
        double a;
        if (double.TryParse(firstStr.Replace(',', '.'), out a))
        {
            Console.Write("b = ");
            string secondStr = Console.ReadLine();
            double b;
            if (double.TryParse(secondStr.Replace(',', '.'), out b))
            {
                Console.Write("c = ");
                string thirdStr = Console.ReadLine();
                double c;
                if (double.TryParse(thirdStr.Replace(',', '.'), out c))
                {
                    Console.WriteLine("********");
                    Console.WriteLine("Solution: ");
                    // Console.WriteLine("a = {0} | b = {1} | c = {2}", a, b, c);
                    double discriminant = Math.Sqrt(b*b-4*a*c);
                    if (!(Double.IsNaN(discriminant))) 
                    {
                        double x1 = (-b + discriminant)/(2*a);
                        double x2 = (-b - discriminant) / (2 * a);
                        Console.WriteLine("x1 = {0:F2} | x2 = {1:F2} ", x1, x2);
                    }
                    else Console.WriteLine("No real roots");
                }
                else Console.WriteLine("Not a valid number");
            }
            else Console.WriteLine("Not a valid number");
        }
        else Console.WriteLine("Not a valid number");
    }
}