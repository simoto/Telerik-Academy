using System;
// Write a program that finds the most frequent number in an array. Example:
// {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

class FrequentNumber
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int number = int.Parse(Console.ReadLine());

        int[] array = new int[number];
        int element = 0;
        int len = 1;
        int bestLen = 0;

        for (int i = 0; i < number; i++)
        {
            Console.Write("Enter Value for {0} element: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                len++;
            }
            else
            {
                if (len > bestLen)
                {
                    bestLen = len;
                    element = array[i];
                }
                len = 1;
            }
        }

        Console.WriteLine("The most frequent is {0} elements of type \"{1}\" .", bestLen, element);
    }
}