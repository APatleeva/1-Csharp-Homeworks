using System;
/*
 Problem 11.* Number as Words

    Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

Examples:
numbers 	number as words
0 	Zero
9 	Nine
10 	Ten
12 	Twelve
19 	Nineteen
25 	Twenty five
98 	Ninety eight
98 	Ninety eight
273 	Two hundred and seventy three
400 	Four hundred
501 	Five hundred and one
617 	Six hundred and seventeen
711 	Seven hundred and eleven
999 	Nine hundred and ninety nine
 */


class NumberAsWords
{
    private static string NumberToName(int number)
    {
        string word;
        switch (number)
        {
            case 0: word = "zero"; break;
            case 1: word = "one"; break;
            case 2: word = "two"; break;
            case 3: word = "three"; break;
            case 4: word = "four"; break;
            case 5: word = "five"; break;
            case 6: word = "six"; break;
            case 7: word = "seven"; break;
            case 8: word = "eight"; break;
            case 9: word = "nine"; break;
            case 10: word = "ten"; break;
            case 11: word = "eleven"; break;
            case 12: word = "twelve"; break;
            case 13: word = "thirteen"; break;
            case 14: word = "fourteen"; break;
            case 15: word = "fifteen"; break;
            case 16: word = "sixteen"; break;
            case 17: word = "seventeen"; break;
            case 18: word = "eighteen"; break;
            case 19: word = "nineteen"; break;
            case 20: word = "twenty"; break;
            case 30: word = "thirty"; break;
            case 40: word = "fourty"; break;
            case 50: word = "fifty"; break;
            case 60: word = "sixty"; break;
            case 70: word = "seventy"; break;
            case 80: word = "eighty"; break;
            case 90: word = "ninety"; break;
            default: word = ""; break;
        }
        return word;
    }

    static void Main()
    {
        do
        {
            Console.Write("Input number from 0 to 999: ");
            int number;
            string name = "";
            if (int.TryParse(Console.ReadLine(), out number))
            {
                int hundreds = number / 100;
                int deci = number - hundreds * 100;
                int digit = number - hundreds * 100 - (deci / 10) * 10;
                if (hundreds > 0)
                {
                    if (deci != 0)
                    {
                        name += NumberToName(hundreds) + " hudndred and ";
                    }
                    else
                    {
                        name += NumberToName(hundreds) + " hudndred";
                    }
                }
                if ((deci <= 20))
                {
                    if (deci!=0) name += NumberToName(deci);
                }
                else
                {
                    if (digit == 0)
                    {
                        name += NumberToName(deci);
                    }
                    else
                    {
                        name += NumberToName(deci / 10 * 10) + " " + NumberToName(digit);
                    }
                }
                if (number==0) name="zero";
                Console.WriteLine(name);
            }
            Console.WriteLine("Press Esc to exit or any other key to continue:");
        }
        while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}

