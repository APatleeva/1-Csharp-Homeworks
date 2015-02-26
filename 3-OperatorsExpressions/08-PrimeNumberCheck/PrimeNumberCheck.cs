using System;
/* Problem 8. Prime Number Check

    Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
    Note: You should check if the number is positive

Examples:
n 	Prime?
1 	false
2 	true
3 	true
4 	false
9 	false
97 	true
51 	false
-3 	false
0 	false
 */
class PrimeNumberCheck
{
    static void Main()
    {
        do
        {
            Console.Write("The number is: ");
            int number;
            bool result = int.TryParse(Console.ReadLine(), out number);
            // int number = int.Parse(Console.ReadLine());
            bool notPrime = (!result) || (number <= 0) || ((number != 2) && (number % 2 == 0)) || ((number != 3) && (number % 3 == 0)) || ((number != 5) && (number % 5 == 0)) || ((number != 7)&&(number % 7 == 0));
            Console.WriteLine("Number\t Prime number\t\n {0}\t{1}", number, notPrime ? false : true);
            Console.WriteLine("Press Esc to exit or any other key to continue:");
        }
        while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}