using System;
/*
 roblem 10. Odd and Even Product

    You are given n integers (given in a single line, separated by a space).
    Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
    Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

Examples:
numbers 	result
2 1 1 6 3 	yes
product = 6 	
	
3 10 4 6 5 1 	yes
product = 60 	
	
4 3 2 5 2 	no
odd_product = 16 	
even_product = 15 	
 */


class OddEvenProduct
{
    static void Main()
    {
        Console.Write("input n integers in a single line, separated by a space: ");
        string strNumbers = Console.ReadLine();
        string[] str_=strNumbers.Split(' ');
        int[] numbers=new int[str_.Length];  
        int prOdd=1, prEven=1;
		for (int i = 0; i < str_.Length; i++)
			{
			  numbers[i]=int.Parse(str_[i]);
              if (i % 2 == 0)
              {
                  prOdd *= numbers[i];
              }
              else
              {
                  prEven *= numbers[i];
              }              
			}
        Console.WriteLine("Product of the odd elements is {0}",prOdd);
        Console.WriteLine("Product of the even elements is {0}", prEven);
        Console.WriteLine("Product of the odd elements is {0} equal to the product of the even elements", prOdd==prEven ?" ":"NOT");
    }
}
