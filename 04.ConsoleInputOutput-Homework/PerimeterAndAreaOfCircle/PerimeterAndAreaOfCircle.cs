//Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class PerimeterAndAreaOfCircle
{
    static void Main()
    {
        Console.Write("Enter the radius: ");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = radius * radius * Math.PI;
        double area = 2 * Math.PI * radius;

        Console.WriteLine("The perimeter is {0} and the area is {1}", perimeter, radius);
    }
}
