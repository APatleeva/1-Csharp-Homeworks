using System;
/* Problem 10. Point Inside a Circle & Outside of a Rectangle

    Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

Examples:
x 	y 	inside K & outside of R
1 	2 	yes
2.5 	2 	no
0 	1 	no
2.5 	1 	no
2 	0 	no
4 	0 	no
2.5 	1.5 	no
2 	1.5 	yes
1 	2.5 	yes
-100 	-100 	no
 */


class PointCyrcleRect
{
    static void Main()
    {
        do
        {
            // circle K({1, 1}, 1.5)
            float radius = 1.5f; float centerx = 1f; float centery = 1f;
            // rectangle (top=1, left=-1, width=6, height=2)
            float topR = 1f; float leftR = -1f; float widthR = 6f; float heightR = 2f;
            Console.WriteLine("X: ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Y: ");
            float y = float.Parse(Console.ReadLine());
            bool inCircle = ((x-centerx)*(x-centerx)+(x-centery)*(x-centery))<=(radius*radius);
            //Console.WriteLine("In the Circle: {0}", inCircle);
            bool outRectangle = (x > leftR+widthR) || (x < leftR)||(y > topR) || (y < topR-heightR);
            //Console.WriteLine("Out of the Rectangle: {0}", outRectangle);
            Console.WriteLine("Point is in a circle and out of the Rectangle: {0}", inCircle && outRectangle);
            Console.WriteLine("Press Esc to exit or any other key to continue:");
        }
        while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}