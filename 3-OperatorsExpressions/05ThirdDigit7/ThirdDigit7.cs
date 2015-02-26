using System;
/* Problem 5. Third Digit is 7?

    Write an expression that checks for given integer if its third digit from right-to-left is 7.

Examples:
n 	Third digit 7?
5 	false
701 	true
9703 	true
877 	false
777877 	false
9999799 	true
 */
// if (number % 1000)/100 == 7
class ThirdDigit7
{
    static void Main()
    {
         do
        {
            Console.WriteLine("Input integer number: ");
            string intNumber = Console.ReadLine();
            int numberLength=intNumber.Length;
            char thirdChar='0';
            if (numberLength >= 3) { thirdChar = intNumber[numberLength - 3]; }
            Console.WriteLine("Third digit 7?\t {0}",thirdChar=='7'? true:false);
            Console.WriteLine("Press Esc to exit or any other key to continue:");
        }
         while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}