﻿using System;
/*
Problem 3. Check for a Play Card

    Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:

character 	Valid card sign?
5 	yes
1 	no
Q 	yes
q 	no
P 	no
10 	yes
500 	no
 */

class CheckCard
{
    static void Main()
    {
        string cards_ = "2,3,4,5,6,7,8,9,10,J,Q,K,A";
        string[] cards = cards_.Split(',');
        Console.Write("Input card sign: ");
        string playingCard = Console.ReadLine();
        bool isValidCard=false;
        foreach (string s in cards)
        {
            if (playingCard==s)
            {
                isValidCard = true;
            }
        }
        Console.WriteLine("Valid card sign? {0}",isValidCard ? "Yes":"No");
    }
}