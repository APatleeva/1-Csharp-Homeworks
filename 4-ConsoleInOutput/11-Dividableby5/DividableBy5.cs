using System;
/* Problem 11.* Numbers in Interval Dividable by Given Number

    Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

Examples:
start 	end 	p 	comments
17 	25 	2 	20, 25
5 	30 	6 	5, 10, 15, 20, 25, 30
3 	33 	6 	5, 10, 15, 20, 25, 30
3 	4 	0 	-
99 	120 	5 	100, 105, 110, 115, 120
107 	196 	18 	110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195
 */


class DividableBy5
{
    static void Main()
    {
        Console.Write("Input start of sequence: ");
        int start;
        if (int.TryParse(Console.ReadLine(), out start))
        {
            Console.Write("Input end of sequence: ");
            int end;
            if (int.TryParse(Console.ReadLine(), out end))
            {
                // p - number of 5-dividable numbers between start and end
                int p = 0;
                string dividable5 = "";
                for (int i = start; i <= end; i++)
                {
                    if (i % 5 == 0)
                    {
                        p += 1;
                        dividable5 += i.ToString() + " ";
                    }
                }
                Console.WriteLine("number of 5-dividable numbers: {0}", p);
                Console.WriteLine("the numbers are: {0}", dividable5);
            }
            else Console.WriteLine("Not a valid number");
        }
    }
}