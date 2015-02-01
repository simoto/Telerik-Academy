using System;
using System.Numerics;

//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

class NFactr
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int input = int.Parse(Console.ReadLine());
        Console.Write("N factorial is: ");
        Console.WriteLine(NumbersToArray(input));
    }

    static BigInteger NumbersToArray(int a)
    {
        BigInteger factorial = 1;

        for (int i = a; i >= 1; i--)
        {
            factorial *= i;
        }

        return factorial;
    }
}