using System;
/*
 * Problem 13. Binary to Decimal Number

    Using loops write a program that converts a binary integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.

Examples:
binary 	decimal
0 	0
11 	3
1010101010101011 	43691
1110000110000101100101000000 	236476736
 */


class BinaryDecimal
{
    static void Main()
    {
        Console.Write("Input binary number: ");
        string binary = Console.ReadLine();        
        long deci=0;        
        for (int i = 0; i < binary.Length; i++)
        {            
            int bin=0;
            if (binary[i]=='0') bin=0;
            if (binary[i]=='1') bin=1;                
            //int bin=Convert.ToInt32(binary[i]); ascii code
            // int bin = (int)Char.GetNumericValue(binary[i]);
            int powInt=1;
            for (int j = binary.Length - 1; j > i; j--)
            {
                powInt *= 2;
            }
            deci += bin * powInt;
        }
        Console.WriteLine(deci);
    }
}