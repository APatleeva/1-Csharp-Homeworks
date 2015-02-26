using System;
/* Problem 2. Gravitation on the Moon

    The gravitational field of the Moon is approximately 17% of that on the Earth.
    Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

Examples:
weight 	weight on the Moon
86 	14.62
74.6 	12.682
53.7 	9.129
 */
class GravitationontheMoon
{
    static void Main()
    {
        do
        {
            Console.WriteLine("Input weight of a man on the Earth:");
            float gravEarth = float.Parse(Console.ReadLine());
            float gravMoon = gravEarth * 0.17f;
            Console.WriteLine("Weight of a man on the moon: {0}", Math.Round(gravMoon, 3));
            Console.WriteLine("Press Esc to exit or any other key to continue:");
        }
        while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
