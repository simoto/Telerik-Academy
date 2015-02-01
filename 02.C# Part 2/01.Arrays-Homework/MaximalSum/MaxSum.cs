using System;

//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.

class MaxSum
{
    static void Main()
    {
        Console.Write("Enter integer for N: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter integer for K: ");
        int numberK = int.Parse(Console.ReadLine());
        int sum = 0;
        int position = 0;
        int max = int.MinValue;
        int[] arrayN = new int[numberN];

        for (int i = 0; i < arrayN.Length; i++)
        {
            Console.Write("Enter element for index {0}: ",i);
            arrayN[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i <= numberN - numberK; i++)
        {
            for (int j = i; j < i + numberK; j++)
            {
                sum += arrayN[j];
            }
            if (sum > max)
            {
                max = sum;
                position = i;
            }
            sum = 0;
        }
        Console.Write("Elements are: ");
        for (int i = position; i < position + numberK; i++)
        {
            Console.Write(arrayN[i] + " ");
        }
        Console.WriteLine();
    }
}
