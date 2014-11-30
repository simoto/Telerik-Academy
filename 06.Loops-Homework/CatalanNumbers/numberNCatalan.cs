using System;
//Write a program to calculate the Nth Catalan number by given N.

class NumberNCatalan
{
    static void Main()
    {
        Console.Write("N= ");
        decimal n = decimal.Parse(Console.ReadLine());

        decimal numerator = n * 2;
        decimal divideOne = n + 1;
        decimal num = 1;
        decimal numTwo = 1;
        decimal numThree = 1;

        for (int i = 1; i <= numerator; i++)
        {
            num *= i;
        }
        for (int i = 1; i <= divideOne; i++)
        {
            numTwo *= i;
        }
        for (int i = 1; i <= n; i++)
        {
            numThree *= i;
        }

        decimal result = num / (numTwo * numThree);
        Console.WriteLine("The result is: {0}.", result);
    }
}

