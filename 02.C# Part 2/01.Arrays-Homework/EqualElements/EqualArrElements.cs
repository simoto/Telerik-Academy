using System;

//Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

class EqualArrElements
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

        Console.WriteLine("The longest sequence is {0} elements of type \"{1}\" .", bestLen, element);
    }
}

