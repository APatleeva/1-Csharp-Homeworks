using System;
using System.Text;

class PrintCardSuite
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        // \u2660 spades
        // \u2663 clubs
        // \u2665 hearts
        // \u2666 diamonds
        Char[] uniChar = { '\u2660', '\u2663', '\u2665', '\u2666' };
        //string[] uniChar = { "spades", "clubs", "hearts", "diamonds" };
        for (int i = 2; i <= 14; i++)
        {
            for (int j = 0; j < uniChar.Length; j++)           
            {
                switch (i)
                {
                    case 11: Console.Write("J of {0} ", uniChar[j]);
                        break;
                    case 12: Console.Write("Q of {0} ", uniChar[j]);
                        break;
                    case 13: Console.Write("K of {0} ", uniChar[j]);
                        break;
                    case 14: Console.Write("A of {0} ", uniChar[j]);
                        break;
                    default: Console.Write("{0} of {1} ", i, uniChar[j]);
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}