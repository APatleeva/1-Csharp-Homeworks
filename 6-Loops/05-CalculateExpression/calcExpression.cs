﻿using System;

/* Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

    Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
    Use only one loop. Print the result with 5 digits after the decimal point.

Examples:
n 	x 	S
3 	2 	2.75000
4 	3 	2.07407
5 	-4 	0.75781
 */

class calcExpression
{
    static void Main()
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x= ");
        int x = int.Parse(Console.ReadLine());
        double s=1; //sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n
        long factoriel=1;
        for (int i = 1; i <= n; i++)
        {
            factoriel *= i;
            s += factoriel / Math.Pow(x, i);
        }
        Console.WriteLine("{0:F5}",s);
    }
}