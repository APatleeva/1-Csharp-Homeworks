using System;
/* 
 * Problem 4. Multiplication Sign

    Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
        Use a sequence of if operators.

Examples:
a 	b 	c 	result
5 	2 	2 	+
-2 	-2 	1 	+
-2 	4 	3 	-
0 	-2.5 	4 	0
-1 	-0.5 	-5.1 	-
*/
class MultiplicationSign
{
    static void Main()
    {
        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c= ");
        double c = double.Parse(Console.ReadLine());
        char sign=' ';
        if ((a==0)||(b==0)||(c==0))
        {
            sign = '0';
        }
        else 
        {
            if (a < 0) 
            {
                if (b < 0)
                {
                    if (c < 0)
                    {
                        sign = '-';
                    }                    
                    else
                    {
                        sign = '+';
                    }
                }                
                else // a <0, b>0
                {
                    if (c < 0)
                    {
                        sign = '+';
                    }                   
                    else
                    {
                        sign = '-';
                    }
                }
            }            
            else // a>0
            {
                if (b < 0)
                {
                    if (c < 0)
                    {
                        sign = '+';
                    }
                    else
                    {
                        sign = '-';
                    }
                }
                else // a>0, b>0
                {
                    if (c < 0)
                    {
                        sign = '-';
                    }
                    else
                    {
                        sign = '+';
                    }
                }
            }

        }

        Console.WriteLine("Sign of the product is: {0}",sign);        
    }
}
