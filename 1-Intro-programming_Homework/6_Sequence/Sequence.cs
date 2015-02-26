using System;

class Sequence
{
    static void Main()
    {
        /*int a = 0;
        int b = -1;
        for (int i = 0; i < 500; i++)
        {
            a = a + 2;
            b = b - 2;
            Console.Write(a + ", " + b);
            if (i != 499) Console.Write(", "); else Console.WriteLine(". ");
        }*/
        Console.WriteLine("Input row lenght: ");
        int RowNumbers = int.Parse(Console.ReadLine());
        for (int i=2; i<=RowNumbers; )
        {
            Console.Write("{0} , {1}", i++, -i++);
            if (i < RowNumbers) Console.Write(", "); else Console.WriteLine(". ");

        }

    }
}
