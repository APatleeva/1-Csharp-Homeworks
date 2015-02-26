using System;
/*
 * Problem 14. Decimal to Binary Number

    Using loops write a program that converts an integer number to its binary representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.

Examples:
decimal 	binary
0 	0
3 	11
43691 	1010101010101011
236476736 	1110000110000101100101000000
 */
class Decimal2Binary
{
    long deci = long.Parse(Console.ReadLine());
    static void Main()
    {
        int deci = int.Parse(Console.ReadLine());
        string binary="";
        while (deci!=0)
        {           
            int binDigit= deci%2;
            if (binDigit==1) binary ="1"+binary; else binary="0"+binary;
            deci = deci / 2;
        }
        
        Console.WriteLine(binary);
    }
}
