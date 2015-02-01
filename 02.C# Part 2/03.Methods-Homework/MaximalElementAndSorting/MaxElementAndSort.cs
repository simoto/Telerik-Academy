using System;
using System.Linq;

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

class MaxElementAndSort
{
    static void Main()
    {
        Console.Write("Enter the numbers in one row with space between them: ");
        string input = Console.ReadLine();

        int[] array = ConvertToArray(input);

        int maxElement;
        int indexOfMaxElement = 0;
        for (int i = 0; i < array.Length; i++)
        {
            maxElement = GetMaxElement(array, i, array.Length - 1);

            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == maxElement)
                {
                    indexOfMaxElement = j;
                }
            }

            int temp;
            temp = array[i];
            array[i] = array[indexOfMaxElement];
            array[indexOfMaxElement] = temp;
        }

        PrintArray(array);
    }

    static int GetMaxElement(int[] array, int startIndex, int endIndex)
    {
        int maxElement = array[startIndex];
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
            }
        }

        return maxElement;
    }

    static int[] ConvertToArray(string input)
    {
        string[] elements = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] array = new int[elements.Length];

        for (int i = 0; i < elements.Length; i++)
        {
            array[i] = int.Parse(elements[i]);
        }

        return array;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i != array.Length - 1)
            {
                Console.Write(array[i] + ", ");
            }
            else
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}