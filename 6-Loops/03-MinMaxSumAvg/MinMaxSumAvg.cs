using System;
/* Problem 3. Min, Max, Sum and Average of N Numbers

    Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
    The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
    The output is like in the examples below.

Example 1:
input 	output
3
2
5
1 	
min = 1
max = 5
sum = 8
avg = 2.67

Example 2:
input 	output
2
-1
4 	
min = -1
max = 4
sum = 3
avg = 1.50
 */

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] numbers = new int[number];
        for (int i = 0; i < number; i++)
        {
            numbers[i]=int.Parse(Console.ReadLine());
        }
        int min=numbers[0], max=numbers[0], sum=0;
        double avg;
        for (int i = 0; i < number; i++)
        {
            sum += numbers[i];
            if (numbers[i] < min) 
            { 
                min = numbers[i]; 
            }
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        avg = (double) sum  / number;
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:F2}",min,max,sum,avg);
    }
}