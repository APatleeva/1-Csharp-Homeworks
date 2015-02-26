using System;

/*Problem 4. Rectangles
Write an expression that calculates rectangle’s perimeter and area by given width and height.
Examples:
width 	height 	perimeter 	area
3 	4 	14 	12
2.5 	3 	11 	7.5
5 	5 	20 	25
 */

class Rectangles
{
    static void Main()
    {
        do
        {
            Console.WriteLine("Input width: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Input height: ");
            double height = double.Parse(Console.ReadLine());
            double perimeter = 2 * (width + height);
            double area = width * height;
            Console.WriteLine("width: {0}; height: {1}; perimeter: {2}; area: {3}", width,height,perimeter,area);
            Console.WriteLine("Press Esc to exit or any other key to continue:");
        }
        while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
