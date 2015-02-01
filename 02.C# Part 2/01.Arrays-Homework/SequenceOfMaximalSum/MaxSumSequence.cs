using System;

/* Write a program that finds the sequence of maximal sum in given array. Example:
 * {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
 * Can you do it with only one loop (with single scan through the elements of the array)?
 */

class MaxSumSequence
{
    static void Main()
    {
        Console.Write("Enter the array length: ");
        int length = int.Parse(Console.ReadLine());

        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("Enter Value for element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        // Kadane algorithm
        int maxSoFar = array[0];
        int maxEndingHere = array[0];

        int begin = 0;
        int beginTemp = 0;
        int end = 0;

        for (int i = 1; i < length; i++)
        {
            if (maxEndingHere < 0)
            {
                maxEndingHere = array[i];
                beginTemp = i;
            }
            else
            {
                maxEndingHere += array[i];
            }

            if (maxEndingHere > maxSoFar)
            {
                maxSoFar = maxEndingHere;

                begin = beginTemp;
                end = i;
            }
        }

        //output
        Console.WriteLine("The maximal sum is {0}", maxSoFar);
        Console.Write("The maximum subarray is: ");
        for (int i = begin; i <= end; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }
}