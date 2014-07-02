//Write an expression that calculates trapezoid's area by given sides a and b and height h.
using System;

class Trapezoid
{
    static void Main()
    {
        Console.Write(@"Size of ""a"" is: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write(@"Size of ""b"" is: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write(@"Size of ""h"" is: ");
        double h = double.Parse(Console.ReadLine());

        Console.Write("Trapezoid's area is: ");
        Console.WriteLine(((a + b) / 2.0) * h);
    }
}
