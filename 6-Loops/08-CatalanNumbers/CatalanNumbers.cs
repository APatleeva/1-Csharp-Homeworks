using System;
/*
 * Problem 8. Catalan Numbers

    In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
    Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

Examples:
n 	Catalan(n)
0 	1
5 	42
10 	16796
15 	9694845
 */

namespace _08_CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("n between 0 and 100, n= ");
            int n = int.Parse(Console.ReadLine());            
            decimal catalan=1;
            for (int k = 2; k <= n; k++)
            {
                catalan *= (decimal) (n + k) / k;
            }
            Console.WriteLine("Catalan({0}) = {1:0}", n, catalan);
        }
    }
}
