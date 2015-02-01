using System;

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

class Surface
{
    static void Main()
    {
        Menu();

        int input = int.Parse(Console.ReadLine());

        if (input == 1)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(Surface(a, b, c));
        }
        else if (input == 2)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine(Surface(a, h));
        }
        else if (input == 3)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            int angle = int.Parse(Console.ReadLine());
            Console.WriteLine(Surface(a, b,angle));
        }
        else
        {
            Console.WriteLine("Invalid input");
            Main();
        }
    }	
 
    static void Menu()
    {
        Console.WriteLine("If you want to enter three side press 1.");
        Console.WriteLine("If you want to enter site and an altitude press 2.");
        Console.WriteLine("If you want to enter two sides and an angle between them press 3.");        
    }

    static double Surface(double a, double b, double c)
    {
        double result = a + b + c;
        return result;
    }

    static double Surface(double a, double h)
    {
        return (a * h) / 2;
    }

    static double Surface(double a, double b, int angle)
    {
        return (a * b * Math.Sin(Math.PI * angle / 180)) / 2;
    }
}