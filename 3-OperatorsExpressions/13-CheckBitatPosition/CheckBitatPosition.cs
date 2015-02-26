using System;
/* Problem 13. Check a Bit at Given Position

    Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

Examples:
n 	binary representation of n 	p 	bit @ p == 1
5 	00000000 00000101 	2 	true
0 	00000000 00000000 	9 	false
15 	00000000 00001111 	1 	true
5343 	00010100 11011111 	7 	true
62241 	11110011 00100001 	11 	false
 */


class CheckBitatPosition
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
            Console.WriteLine("The value of bit {0} is 1\t {1}", position, bit==1);
            Console.WriteLine("Press Esc to exit or any other key to continue:");
        }
        while (Console.ReadKey(true).Key != ConsoleKey.Escape);

    }
}