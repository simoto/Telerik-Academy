//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

using System;
class QuadraticEquationSolver
{
    static void Main()
    {
        Console.Write("Enter coefficient a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient c: ");
        double c = double.Parse(Console.ReadLine());

        double d = (b * b) - 4 * a * c;

        if (d == 0)
        {
            Console.WriteLine("One root: {0}", (-b / (2 * a)));
        }
        else if (d < 0)
        {
            Console.WriteLine("No real roots");
        }
        else
        {
            Console.WriteLine("x1 = {0}", (-b + Math.Sqrt(d))/(2 * a));
            Console.WriteLine("x2 = {0}", (-b - Math.Sqrt(d)) / (2 * a));
        }
    }
}