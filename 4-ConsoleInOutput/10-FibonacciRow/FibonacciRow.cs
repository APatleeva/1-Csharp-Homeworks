using System;
/* 
    Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

Note: You may need to learn how to use loops.

Examples:
n 	comments
1 	0
3 	0 1 1
10 	0 1 1 2 3 5 8 13 21 34
 */

class FibonacciRow
{
    static void Main()
    {
        Console.Write("Input number of members of the Fibonacci sequence: ");
        uint number;        
        if (uint.TryParse(Console.ReadLine(), out number))
        {
            uint member1 = 0;
            uint member2 = 1;            
            Console.Write(member1 + ", " + member2 + ", ");
            if (number > 2)
            {
                for (int i = 3; i <= number; i++)
                {
                    uint cMember = member1 + member2;
                    member1 = member2;
                    member2 = cMember;
                    if (i != number) Console.Write(cMember + ", "); else Console.WriteLine(cMember);
                }
            }
        }
        else Console.WriteLine("Not a valid number");    
    }
}
/*
using System;
using System.Numerics;

class Fibonacci
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        BigInteger[] fibonacciNumbers = new BigInteger[n];

        if (n == 1)
        {
            Console.WriteLine(1);
        }
        else
        {
            fibonacciNumbers[0] = 0;
            fibonacciNumbers[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
            }

            Console.WriteLine(
                "The first {0} members of the Fibonacci sequence is:", n);

            for (int k = 0; k < fibonacciNumbers.Length; k++)
            {
                if (k == fibonacciNumbers.Length -1)
                {
                    Console.Write("{0}", fibonacciNumbers[k]);
                }
                else
                {
                    Console.Write("{0}, ", fibonacciNumbers[k]);
                }
            }
            Console.WriteLine();
        }
    }
}
*/