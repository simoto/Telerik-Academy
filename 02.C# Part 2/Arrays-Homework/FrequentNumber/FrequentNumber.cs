using System;

//Write a program that finds the most frequent number in an array.
class FrequentNumber
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

        int bestNumber = integerSequence[0];
        int bestTimeRepeating = 1;
        int currentNumber;
        int currentRepeating = 1;

        for (int i = 0; i < integerSequence.Length; i++)
        {
            currentNumber = integerSequence[i];
            for (int j = 0; j < integerSequence.Length; j++)
            {
                if (j != i)
                {
                    if (integerSequence[j] == currentNumber)
                    {
                        currentRepeating++;
                    }
                }               
            }

            if (currentRepeating > bestTimeRepeating)
            {
                bestTimeRepeating = currentRepeating;
                bestNumber = currentNumber;
                currentRepeating = 1;
            }
            else
            {
                currentRepeating = 1;
            }
        }

        Console.WriteLine("{0}({1} times)", bestNumber, bestTimeRepeating);
    }
}