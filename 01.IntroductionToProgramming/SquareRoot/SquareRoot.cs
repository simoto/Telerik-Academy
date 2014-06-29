//Create a console application that calculates and prints the square root of the number 12345.
//Find in Internet “how to calculate square root in C#”.
using System;

class SquareRoot
{
    static void Main()
    {
        double number = 12345;
        double squareRoot = Math.Sqrt(number);
        Console.WriteLine(squareRoot);
    }
}
