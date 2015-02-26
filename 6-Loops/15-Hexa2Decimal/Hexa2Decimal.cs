using System;
/* Problem 15. Hexadecimal to Decimal Number

    Using loops write a program that converts a hexadecimal integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.

Examples:
hexadecimal 	decimal
FE 	254
1AE3 	6883
4ED528CBB4 	338583669684 
 */
// A=10, B=11, C=12, D=13, E=14, F=15
class Hexa2Decimal
{
    static void Main()
    {
        string hexa = Console.ReadLine();
        ulong deci = 0;
        for (int i = 0; i < hexa.Length; i++)
        {
            long bin = 0;
            if ((hexa[i]>='0')&&(hexa[i]<='9')) bin=(int)Char.GetNumericValue(hexa[i]);
            switch (hexa[i])
            {
                case 'A': bin = 10; break;
                case 'B': bin = 11; break;
                case 'C': bin = 12; break;
                case 'D': bin = 13; break;
                case 'E': bin = 14; break;
                case 'F': bin = 15; break;
            }
            //int bin=Convert.ToInt32(binary[i]); ascii code
            // int bin = (int)Char.GetNumericValue(binary[i]);
            int powInt = 1;
            for (int j = hexa.Length - 1; j > i; j--)
            {
                powInt *= 16;
            }
            deci += (ulong) bin * (ulong) powInt;
        }
        Console.WriteLine(deci);
    }
}