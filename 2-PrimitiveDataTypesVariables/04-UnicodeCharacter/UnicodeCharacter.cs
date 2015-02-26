using System;
using System.Text;

/*
Problem 4. Unicode Character
Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
 */

namespace _04_UnicodeCharacter
{
    class UnicodeCharacter
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Char uniChar = '\u002A';
            Console.WriteLine(uniChar);            
        }
    }
}
