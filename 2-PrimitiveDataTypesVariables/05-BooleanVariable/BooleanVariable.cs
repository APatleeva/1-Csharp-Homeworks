using System;

/*
 Problem 5. Boolean Variable

    Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
    Print it on the console.
*/

namespace _05_BooleanVariable
{
    class BooleanVariable
    {
        static void Main()
        {
            Boolean isFemale = true;
            //if (isFemale) Console.WriteLine("My gender is female");
            //else Console.WriteLine("My gender is male");
            Console.WriteLine("I am female - {0}", isFemale);
        }
    }
}
