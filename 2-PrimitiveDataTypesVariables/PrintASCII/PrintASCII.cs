using System;
using System.Text;

/*
 Problem 14.* Print the ASCII Table
Find online more information about ASCII (American Standard Code for Information Interchange) and 
write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
 */

class PrintASCII
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.ASCII;
// ASCII is a 7bit code, includes definitions for 128 characters: 33 are non-printing control characters (0-31 and 127) and 95 printable characters, including the space
        for (byte i = 32; i < 127; i++)
        {
            Console.Write(" {0} ",(char) i);
        }
    }
}
