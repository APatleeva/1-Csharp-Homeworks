using System;

/* Problem 7. Quotes in Strings

    Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
    Do the above in two different ways - with and without using quoted strings.
    Print the variables to ensure that their value was correctly defined.
*/

namespace _07_QuotesString
{
    class QuotesString
    {
        static void Main()
        {
            string stringValue1 = "The \"use\" of quotations causes difficulties.";
            string stringValue2 = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine("Value 1: {0}",stringValue1);
            Console.WriteLine("Value 2: {0}",stringValue2);
        }
    }
}
