using System;
using System.Threading;
using System.Globalization;
/* Problem 5. Formatting Numbers

    Write a program that reads 3 numbers:
        integer a (0 <= a <= 500)
        floating-point b
        floating-point c
    The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
        The number a should be printed in hexadecimal, left aligned
        Then the number a should be printed in binary form, padded with zeroes
        The number b should be printed with 2 digits after the decimal point, right aligned
        The number c should be printed with 3 digits after the decimal point, left aligned.

Examples:
a 	b 	c 	result
254 	11.6 	0.5 	FE |0011111110| 11.60|0.500 |
499 	-0.5559 	10000 	1F3 |0111110011| -0.56|10000.000 |
0 	3 	-0.1234 	0 |0000000000| 3.00|-0.123 |
 */

    class FormattingNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Input first number of type integer between 0 and 500: ");
            string firstStr = Console.ReadLine();
            int firstNumber;
            if (int.TryParse(firstStr.Replace(',', '.'), out firstNumber)&&(firstNumber<=500)&&(firstNumber>=0))
            {
                Console.Write("Input second number: ");
                string secondStr = Console.ReadLine();
                float secondNumber;
                if (float.TryParse(secondStr.Replace(',', '.'), out secondNumber))
                {
                    Console.Write("Input third real number: ");
                    string thirdStr = Console.ReadLine();
                    float thirdNumber;                    
                    if (float.TryParse(thirdStr.Replace(',', '.'), out thirdNumber))
                    {
                        Console.WriteLine("{0,-10:x} | {1,10} | {2,10:F2} | {3,-10:F3} |", firstNumber, Convert.ToString(firstNumber,2).PadLeft(10,'0'), secondNumber,thirdNumber);
                    }
                    else Console.WriteLine("Not a valid number");
                }
                else Console.WriteLine("Not a valid number");
            }
            else Console.WriteLine("Not a valid number");
        }
}