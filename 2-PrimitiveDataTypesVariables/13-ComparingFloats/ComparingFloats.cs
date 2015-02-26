using System;
/* Problem 13.* Comparing Floats

    Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
 */
class ComparingFloats
{
    static void Main()
    {   
        Console.WriteLine("Input first number of type float: ");
        string first=Console.ReadLine();
        float firstFloat = float.Parse(first);
        Console.WriteLine("Input second number of type float: ");
        string second = Console.ReadLine();
        float secondFloat = float.Parse(second);  
        float precision = 1e-6f;
        Console.WriteLine("Precision: "+precision);
        if (Math.Abs(firstFloat - secondFloat) < precision) Console.WriteLine("Numbers are equal");
        else Console.WriteLine("Unequal numbers");       
    }
}
