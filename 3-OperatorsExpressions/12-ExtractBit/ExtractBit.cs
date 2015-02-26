using System;
/* Problem 12. Extract Bit from Integer

    Write an expression that extracts from given integer n the value of given bit at index p.

Examples:
n 	binary representation 	p 	bit @ p
5 	00000000 00000101 	2 	1
0 	00000000 00000000 	9 	0
15 	00000000 00001111 	1 	1
5343 	00010100 11011111 	7 	1
62241 	11110011 00100001 	11 	0
 */

class ExtractBit
{
    static void Main()
    {
        do
        {
            Console.WriteLine("Input integer number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Input bit position: ");
            int position = int.Parse(Console.ReadLine()); 
            int mask = 1 << position;
            int result = mask & number;
            int bit = result >> position;
            Console.WriteLine("Binary representation of integer number: {0}", Convert.ToString(number, 2).PadLeft(16, '0'));
            Console.WriteLine("The value of bit {0} is: {1}", position, bit);
            Console.WriteLine("Press Esc to exit or any other key to continue:");
        }
        while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}