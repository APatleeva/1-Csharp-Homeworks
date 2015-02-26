using System;
/* Problem 7. Point in a Circle

    Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

Examples:
x 	y 	inside
0 	1 	true
-2 	0 	true
-1 	2 	false
1.5 	-1 	true
-1.5 	-1.5 	false
100 	-30 	false
0 	0 	true
0.2 	-0.8 	true
0.9 	-1.93 	false
1 	1.655 	true
 */

class PointInCircle
{
    static void Main()
    {
        do
        {
            // circle K({0, 0}, 2)
            float radius = 2f; //float centerx = 0f; float centery = 0f;
            Console.WriteLine("X: ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Y: ");
            float y = float.Parse(Console.ReadLine());
            bool inCircle = (x * x + y * y) <= (radius * radius);
            Console.WriteLine("Point is in a circle: {0}", inCircle);
            Console.WriteLine("Press Esc to exit or any other key to continue:");
        }
        while (Console.ReadKey(true).Key != ConsoleKey.Escape);
   }
}
