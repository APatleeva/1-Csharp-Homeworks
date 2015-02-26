using System;
/* Problem 9. Sum of n Numbers

    Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

Examples:
numbers 	sum
3 	90
20 	
60 	
10 	
5 	6.5
2 	
-1 	
-0.5 	
4 	
2 	
1 	1
1 	*/

class SumofNumbers
{
    static void Main()
    {
        Console.Write("Input number: ");
        int number;
        if (int.TryParse(Console.ReadLine(), out number))
        {
            double sum = 0;
            double addend;
            for (int i=1; i<=number;i++)
            {
                Console.Write("Input number {0} of {1} addends: ",i,number);
                if (double.TryParse(Console.ReadLine(), out addend))
                    sum += addend;
                else
                {
                    Console.WriteLine("Not a valid number");
                    i--;
                }
            }
            Console.WriteLine("sum = {0}",sum);
        }
        else Console.WriteLine("Not a valid number");
    }
}