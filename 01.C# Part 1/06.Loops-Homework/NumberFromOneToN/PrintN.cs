//Write a program that prints all the numbers from 1 to N.
using System;

class PrintN
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0 )
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            } 
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}

