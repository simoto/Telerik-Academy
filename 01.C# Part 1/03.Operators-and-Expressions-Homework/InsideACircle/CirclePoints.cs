//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
using System;

class CirclePoints
{
    static void Main()
    {
        Console.Write("Insert x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Insert y: ");
        int y = int.Parse(Console.ReadLine());

        bool o = Math.Sqrt(x * x + y * y) <= 5;

        if (o == true)
        {
            Console.WriteLine("The point is inside the circle.");
        }
        else
        {
            Console.WriteLine("The point is outside the circle.");
        }
    }
}
