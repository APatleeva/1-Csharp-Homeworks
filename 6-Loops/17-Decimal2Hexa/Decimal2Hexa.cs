using System;
/*
 Problem 16. Decimal to Hexadecimal Number

    Using loops write a program that converts an integer number to its hexadecimal representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.

Examples:
decimal 	hexadecimal
254 	FE
6883 	1AE3
338583669684 	4ED528CBB4
 */
class Decimal2Hexa
{    
    static void Main()
    {
        ulong deci = ulong.Parse(Console.ReadLine());
        string hexa = "";
        while (deci != 0)
        {
            ulong Digit = deci % 16;
            switch (Digit)
            {
                case 10: hexa = "A" + hexa; break;
                case 11: hexa = "B" + hexa; break;
                case 12: hexa = "C" + hexa; break;
                case 13: hexa = "D" + hexa; break;
                case 14: hexa = "E" + hexa; break;
                case 15: hexa = "F" + hexa; break;
                default: 
                    {
                     if ((Digit>=0)&&(Digit<=9))
                     {
                         hexa = Digit.ToString() + hexa;                         
                     }
                    }; break;
            }            
            deci = deci / 16;
        }
        Console.WriteLine(hexa);
    }
}