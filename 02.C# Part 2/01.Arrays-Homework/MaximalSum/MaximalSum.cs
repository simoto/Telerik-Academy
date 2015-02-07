using System;

//Write a program that finds the sequence of maximal sum in given array.

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter an array foreach element separated by \",\": ");
        string input = Console.ReadLine();
        string[] sequence = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] integerSequence = new int[sequence.Length];

        for (int i = 0; i < sequence.Length; i++)
        {
            integerSequence[i] = int.Parse(sequence[i]);
        }

        MaxSubarray(integerSequence);
    }

    //Kadane's algorithm
    static void MaxSubarray(int[] array)
    {

        int currentSum = array[0];
        int startIndex = 0;
        int endIndex = 0;
        int tempStartIndex = 0;
        int maxSum = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (currentSum < 0)
            {
                currentSum = array[i];
                tempStartIndex = i;
            }
            else
            {
                currentSum += array[i];
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                startIndex = tempStartIndex;
                endIndex = i;
            }
        }

        for (int i = startIndex; i <= endIndex; i++)
        {
            if (i == endIndex)
            {
                Console.WriteLine(array[i]);
            }
            else
            {
                Console.Write(array[i] + ", ");
            }
        }
    }


}
