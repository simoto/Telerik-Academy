using System;

// Write a method GetMax() with two parameters that returns the bigger of two integers.
// Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

class BiggerInteger
{
    static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else if (b > a)
        {
            return b; 
        }
        else
        {
            return a;
        }
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int third = int.Parse(Console.ReadLine());

        int bigger = GetMax(first, second);
        int biggest = GetMax(bigger, third);

        Console.WriteLine("The biggest number is {0}.", biggest);
    }
}