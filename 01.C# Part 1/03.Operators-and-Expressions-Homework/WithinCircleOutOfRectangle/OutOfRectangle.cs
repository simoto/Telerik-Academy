//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)
//and out of the rectangle R(top=1, left=-1, width=6, height=2).
using System;

class OutOfRectangle
{
    static void Main()
    {
        Console.Write("Insert x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Insert y: ");
        double y = double.Parse(Console.ReadLine());

        double xCenter = 1.0;
        double yCenter = 1.0;

        bool o = Math.Sqrt((x - xCenter) * (x - xCenter) + (y - yCenter) * (y - yCenter)) <= 3;

        if (o == true)
        {
            if (x < -1 || x > 6 || y < 1 || y > 2)
            {
                Console.WriteLine("The point is inside the circle and outside the rectangle.");
            }
            else
            {
                Console.WriteLine("The point is inside the rectangle.");
            }
        }
        else
        {
            Console.WriteLine("The point is outside the circle.");
        }
    }
}
