using System;

// Write a program that finds in given array of integers a sequence of given sum S (if present). 
// Example: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

class SequenceSum
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];

        for (int i = 0; i < number; i++)
        {
            Console.Write("Enter Value for {0} element: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter the sum: ");
        int S = int.Parse(Console.ReadLine());
        int start = 0;
        int sum = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            sum += array[i];
            start = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                sum += array[j];
                if (sum == S)
                {
                    for (int k = start; k <= j; k++)
                    {
                        Console.Write(array[k] + " ");
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