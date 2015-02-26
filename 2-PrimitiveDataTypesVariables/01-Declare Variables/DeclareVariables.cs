using System;

/*
    Problem 1. Declare Variables

    Declare five variables choosing for each of them the most appropriate of the types 
    byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
    Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
 */

namespace _01_Declare_Variables
{
    class DeclareVariables
    {
        static void Main()
        {
            ushort varUShort=52130; 
            sbyte varSByte=-115;
            uint varUInt=4825932;
            byte varByte = 97;
            short varShort=-10000;
            Console.WriteLine("Variable of type unsigned short (16-bit): {0};\nVariable of type sbyte (8-bit): {1};", varUShort, varSByte);
            Console.WriteLine("Variable of type unsigned integer (32-bit): {0};\nVariable of type byte (8-bit): {1};", varUInt, varByte);
            Console.WriteLine("Variable of type short (16-bit): {0}", varShort);
        }
    }
}
