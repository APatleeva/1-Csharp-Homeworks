using System;

/* Problem 6. Calculate N! / K!

    Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
    Use only one loop.

Examples:
n 	k 	n! / k!
5 	2 	60
6 	5 	6
8 	3 	6720
 */

class calcExpression
{
    static void Main()
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k= ");
        int k = int.Parse(Console.ReadLine());
        double quotient = 1; // quotient = n! / k!
        long factorielK = 1;
        long factorielN = 1;
        if ((k > 1) && (k < n))
        {
            for (int i = 1; i <= n; i++)
            {
                factorielN *= i;
                if (i<=k) factorielK *= i;                
            }
            quotient = factorielN / factorielK;
            Console.WriteLine("{0}", quotient);
        }
        else 
        { 
            Console.WriteLine("invalid range of numbers"); 
        }
    }
}
