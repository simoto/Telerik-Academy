using System;
using System.Numerics;
//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

class FactorialCalc
{
    static void Main()
    {
        //input need to be (1<N<K)
        Console.Write("N!= ");
        int n = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        Console.Write("K!= ");
        int k = int.Parse(Console.ReadLine());
        if ((1 < n) && (n < k))
        {
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            for (int i = 1; i <= k; i++)
            {
                kFactorial *= i;
            }

            BigInteger product = nFactorial * kFactorial;
            BigInteger subtraction = kFactorial - nFactorial;
            Console.WriteLine(product/subtraction);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}

