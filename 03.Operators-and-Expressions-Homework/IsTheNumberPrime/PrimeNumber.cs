//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Insert your number: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 101)
        {
            Console.WriteLine("You have declarated too long value.You can use values between 1 and 100");
        }
        else if (1 > number)
        {
            Console.WriteLine("You have declarated too small value.You can use values between 1 and 100");
        }
        else
        {
            if (number == 2 || number == 3 || number == 5 || number == 7)
            {
                Console.WriteLine("Number is prime");
            }
            else
            {
                if (((number % 2) != 0) && ((number % 3) != 0) && ((number) % 5 != 0) && ((number % 7) != 0))
                {
                    Console.WriteLine("Number is prime");
                }
                else
                {
                    Console.WriteLine("Number is not prime");
                }
            }
        }
    }
}
