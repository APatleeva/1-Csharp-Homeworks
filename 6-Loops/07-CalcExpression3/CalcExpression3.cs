using System;
using System.Numerics;

/* Problem 7. Calculate N! / (K! * (N-K)!)

    In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
    Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

Examples:
n 	k 	n! / (k! * (n-k)!)
3 	2 	3
4 	2 	6
10 	6 	210
52 	5 	2598960
 */

class CalcExpression3
{
    static void Main()
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k= ");
        int k = int.Parse(Console.ReadLine());
        BigInteger quotient = 1; // quotient = n! / k!
        BigInteger factorielK = 1;
        BigInteger factorielN = 1;
        BigInteger factorielNK=1;
        if ((k > 1) && (k < n))
        {
            for (int i = 1; i <= n; i++)
            {
                factorielN *= i;
                if (i <= k) factorielK *= i;
                if (i <= n-k) factorielNK *= i;
            }            
            quotient = factorielN / (factorielK*factorielNK);
            Console.WriteLine("{0}", quotient);
        }
        else
        {
            Console.WriteLine("invalid range of numbers");
        }
    }
}

