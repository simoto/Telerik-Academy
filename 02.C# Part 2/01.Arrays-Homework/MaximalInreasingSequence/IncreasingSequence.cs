using System;

//Write a program that finds the maximal increasing sequence in an array. 
//Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

class IncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int number = int.Parse(Console.ReadLine());

        int[] array = new int[number];
        int len = 1;
        int bestLen = 0;

        for (int i = 0; i < number; i++)
        {
            Console.Write("Enter Value for {0} element: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1] )
            {
                len++;
            }
            else
            {
                if (len > bestLen)
                {
                    bestLen = len;                   
                }
                len = 1;
            }
        }

        Console.WriteLine("The maximal increasing sequence is of {0} elements", bestLen);
    }
}