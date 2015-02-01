//Write a program that enters the coefficients a, b and c of a quadratic equation
//		a*x2 + b*x + c = 0
//and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter number for \"a\": ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number for \"b\": ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number for \"c\": ");
        double c = double.Parse(Console.ReadLine());

        double d = (b * b) - 4 * a * c;

        if (d == 0)
        {
            Console.WriteLine("One root {0}", (-b / (2 * a)));
        }
        else if(d > 0)
        {
            Console.WriteLine("Two roots: x1 = {0}, x2 = {1}", ((-b + Math.Sqrt(d)) / 2 * a), (-b - Math.Sqrt(d)) / 2 * a);
        }
        else
        {
            Console.WriteLine("No real roots!");
        }
    }
}
