using System;

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

class SquareRoot
{
    static void Main()
    {
        Console.Write("Enter number: ");
        try
        {
            double number = double.Parse(Console.ReadLine());
            number = Math.Sqrt(number);
            Console.WriteLine("The square root of the number is: {0}",number);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
