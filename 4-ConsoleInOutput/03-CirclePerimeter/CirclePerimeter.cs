using System;
using System.Threading;
using System.Globalization;
/* 
    Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

Examples:
r 	perimeter 	area
2 	12.57 	12.57
3.5 	21.99 	38.48
 */


class CirclePerimeter
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 
        Console.Write("Input radius of a circle: ");
        string radiusS = Console.ReadLine();
        double radius;       
        if (double.TryParse(radiusS.Replace(',','.'), out radius))
        {
            double area = Math.PI * radius * radius;
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("Circle radius = {0:F2}\nCircle perimeter = {1:F2}\nCircle area = {2:F2}", radius, perimeter, area);
        }
        else Console.WriteLine("Not a valid number");
    }
}
