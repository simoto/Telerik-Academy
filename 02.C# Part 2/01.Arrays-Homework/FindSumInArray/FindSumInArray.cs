using System;

//Write a program that finds in given array of integers a sequence of given sum S (if present).

class FindSumInArray
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

        Console.Write("Enter the sum: ");
        int S = int.Parse(Console.ReadLine());
        int start = 0;
        int sum = 0;
        for (int i = 0; i < integerSequence.Length - 1; i++)
        {
            sum += integerSequence[i];
            start = i;
            for (int j = i + 1; j < integerSequence.Length; j++)
            {
                sum += integerSequence[j];
                if (sum == S)
                {
                    for (int k = start; k <= j; k++)
                    {
                        Console.Write(integerSequence[k] + " ");
                    }

                    Console.WriteLine();
                    return;
                }
            }

            sum = 0;
        }
        Console.WriteLine("The sum is not present in the array.");
    }
}