//Write an expression that calculates rectangle’s area by given width and height.
using System;

class Area
{
    static void Main()
    {
        Console.Write("Insert rectangle's width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Insert rectangle's height: ");
        double height = double.Parse(Console.ReadLine());

        double area = width * height;
        Console.WriteLine("Rectangle's area is : " + area);

    }
}
