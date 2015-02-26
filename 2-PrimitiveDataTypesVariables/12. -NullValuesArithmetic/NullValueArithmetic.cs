using System;
/* Problem 12. Null Values Arithmetic

    Create a program that assigns null values to an integer and to a double variable.
    Try to print these variables at the console.
    Try to add some number or the null literal to these variables and print the result.
*/

class NullValueArithmetic
{
    static void Main(string[] args)
    {
        int? nullValueI = null;
        double? nullValueD = null;
        int someNumber = 5;
        Console.WriteLine("Integer type null value: {0} \nDouble type null value: {1}", nullValueI, nullValueD);
        Console.WriteLine("Integer type null value + "+ someNumber.ToString() + " = {0} \nDouble type null value + " + someNumber.ToString() + " = {1}", nullValueI+someNumber, nullValueD+someNumber);
        Console.WriteLine("Integer type null value plus null: {0} \nDouble type null value plus null: {1}", nullValueI+null, nullValueD+null);
    }
}
