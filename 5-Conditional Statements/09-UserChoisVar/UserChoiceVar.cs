using System;
/*
 *Problem 9. Play with Int, Double and String

    Write a program that, depending on the user’s choice, inputs an int, double or string variable.
        If the variable is int or double, the program increases it by one.
        If the variable is a string, the program appends * at the end.
    Print the result at the console. Use switch statement.

Example 1:
program 	user
Please choose a type: 	
1 --> int 	
2 --> double 	
3 --> string 	3
	
Please enter a string: 	hello
	
hello* 	

Example 2:
program 	user
Please choose a type: 	
1 --> int 	
2 --> double 	2
3 --> string 	
	
Please enter a double: 	1.5
	
2.5 	
 */

class UserChoiceVar
{
    static void Main()
    {
        Console.Write(
@"Please choose a type: 	
1 --> int 	
2 --> double 	
3 --> string ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: 
                {
                    Console.Write("Input integer number: ");
                    int intValue = int.Parse(Console.ReadLine());
                    Console.WriteLine("integer number: {0}",intValue+1);
                } break;
            case 2:
                {
                    Console.Write("Input real number: ");
                    double realValue = double.Parse(Console.ReadLine());
                    Console.WriteLine("real number: {0}",realValue+1);
                } break;
            case 3:
                {
                    Console.Write("Input string: ");
                    string stringValue = Console.ReadLine();
                    Console.WriteLine("string value: {0}*",stringValue);
                } break;
            default: Console.WriteLine("Invalid input");
                break;
        }
    }
}