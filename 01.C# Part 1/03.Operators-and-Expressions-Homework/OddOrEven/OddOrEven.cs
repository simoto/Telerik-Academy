//Write an expression that checks if given integer is odd or even.
using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Insert your number: ");

        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("Your number is even.");
        }
        else
        {
            Console.WriteLine("Your number is odd.");
        }
    }
}
