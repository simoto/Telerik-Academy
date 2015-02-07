using System;

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

class SelectionSort
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

        //Selection sort
        int iMin;

        for (int j = 0; j < integerSequence.Length - 1; j++)
        {
            iMin = j;

            for (int i = j + 1; i < integerSequence.Length; i++)
            {
                if (integerSequence[i] < integerSequence[iMin])
                {
                    iMin = i;
                }
            }

            if (iMin != j)
            {
                int tempValue = integerSequence[j];
                integerSequence[j] = integerSequence[iMin];
                integerSequence[iMin] = tempValue;
            }
        }

        Console.WriteLine(string.Join(", ", integerSequence));
    }
}