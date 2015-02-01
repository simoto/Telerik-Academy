using System;
/* Write a program that calculates the greatest common divisor (GCD) of given two numbers.
Use the Euclidean algorithm (find it in Internet). */

class GCD
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        decimal a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        decimal b = int.Parse(Console.ReadLine());
        decimal num = a;
        decimal numTwo = b;
        while (num != 0 && numTwo != 0)
        {
            if (num > numTwo)
            {
                num %= numTwo;
            }
            else
            {
                numTwo %= num;
            }
        }

        if (num == 0)
        {
            Console.WriteLine("Greatest divisor is : {0}.", numTwo);
        }
        else
        {
            Console.WriteLine("Greatest divisor is : {0}.", num);
        }
    }
}
