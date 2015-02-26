using System;
/* Problem 6. Four-Digit Number

    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
        Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
        Prints on the console the number in reversed order: dcba (in our example 1102).
        Puts the last digit in the first position: dabc (in our example 1201).
        Exchanges the second and the third digits: acbd (in our example 2101).

The number has always exactly 4 digits and cannot start with 0.

Examples:
n 	sum of digits 	reversed 	last digit in front 	second and third digits exchanged
2011 	4 	1102 	1201 	2101
3333 	12 	3333 	3333 	3333
9876 	30 	6789 	6987 	9786
 */
/*
 int n = int.Parse(Console.ReadLine());

        int d = n % 10;
        n = n / 10;
        int c = n % 10;
        n = n / 10;
        int b = n % 10;
        n = n / 10;
        int a = n % 10;

        Console.WriteLine("{3}{2}{1}{0}",a,b,c,d);
        Console.WriteLine("Sum: {0}",(a+b+c+d));
        Console.WriteLine("{3}{0}{1}{2}", a, b, c, d);
        Console.WriteLine("{0}{2}{1}{3}", a, b, c, d);
 */

class Program
{
    static void Main()
    {
        do
        {
            Console.WriteLine("Input 4-digit integer number: ");
            string intNumber = Console.ReadLine();
            int Number;
            bool result = int.TryParse(intNumber, out Number);            
            int numberLength = intNumber.Length;
            int sumOfDigits=0;
            string reversed="";
            string lastFront = "";
            string exchange = "";
            if (result && (numberLength == 4))
            {
                for (int i = 0; i < numberLength; i++)
                {                    
                    reversed += intNumber[numberLength - 1 - i];
                    if (i != numberLength - 1) lastFront += intNumber[i]; else lastFront = intNumber[i] + lastFront;
                    if (i == 1) exchange += intNumber[i + 1]; else if (i == 2) exchange += intNumber[i - 1]; else exchange += intNumber[i];
                }
                for (int i = numberLength - 1; i >= 0; i--)
                {
                    int digit = (int)(Number / Math.Pow(10, i));
                    sumOfDigits += digit;
                    Number -= (int)(digit * Math.Pow(10, i));
                }                
                Console.WriteLine("n | sum of digits | reversed | last digit in front | second and third digits exchanged");
                Console.WriteLine(intNumber + "\t" + sumOfDigits + "\t" + reversed + "\t"+ lastFront+ "\t"+exchange);           
            }
            else Console.WriteLine("Not a number or the number is not 4-digit");
            Console.WriteLine("Press Esc to exit or any other key to continue:");
        }
        while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}

