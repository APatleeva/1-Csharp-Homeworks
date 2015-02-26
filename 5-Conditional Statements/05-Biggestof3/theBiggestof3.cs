using System;
/* Problem 5. The Biggest of 3 Numbers

    Write a program that finds the biggest of three numbers.

Examples:
a 	b 	c 	biggest
5 	2 	2 	5
-2 	-2 	1 	1
-2 	4 	3 	4
0 	-2.5 	5 	5
-0.1 	-0.5 	-1.1 	-0.1
 */


class theBiggestof3
{
    static void Main()
    {
        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c= ");
        double c = double.Parse(Console.ReadLine());
        double biggestNumber;
        if (a>=b)
        {
            biggestNumber = a;
            if (a<=c) 
            {
                biggestNumber=c;
            }	
        }
        else
        {
            biggestNumber = b;
            if (b<=c)
            {
                biggestNumber=c;
            }
        }
        Console.WriteLine("The biggest number is: {0}",biggestNumber);
    }
}