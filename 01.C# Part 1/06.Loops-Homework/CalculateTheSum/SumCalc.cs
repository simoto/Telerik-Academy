using System;
using System.Numerics;
//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N

class SumCalc
{
    static void Main()
    {
        Console.Write("N= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("X= ");
        int x = int.Parse(Console.ReadLine());
        decimal sum = 1;
        decimal nFactorial = 1;
        for (int i = 1,p = 1; i <= n ;p++,i++)
        {
            sum += (nFactorial *= i)/(decimal)Math.Pow(x, p);
        }

        Console.WriteLine(sum);
    }
}

