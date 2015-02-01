using System;
using System.Numerics;
//Write a program that calculates N!/K! for given N and K (1<K<N).

class FactorialDividing
{
    static void Main()
    {
        Console.Write("N!= ");
        int n = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        Console.Write("K!= ");
        int k = int.Parse(Console.ReadLine());
        if ((1 < k) && (k < n))
        {
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            for (int i = 1; i <= k; i++)
            {
                kFactorial *= i;
            }
            Console.WriteLine("The result is : {0}", (nFactorial/kFactorial));
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}

