using System;

/* Sorting an array means to arrange its elements in increasing order.
 * Write a program to sort an array. Use the "selection sort" algorithm:
 * Find the smallest element, move it at the first position, 
 * find the smallest from the rest, move it at the second position, etc.
 */
class ElementSorting
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int number = int.Parse(Console.ReadLine());

        int[] array = new int[number];

        for (int i = 0; i < array.Length; i++)
        {
           Console.Write("Enter Value for {0} element: ", i);
           array[i] = int.Parse(Console.ReadLine());
        }

        //selection sort
        int swap = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            int index = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[index])
                {
                    index = j;
                }
            }
            swap = array[i];
            array[i] = array[index];
            array[index] = swap;
        }
        //printing array after sorting
        Console.Write("Array items after sorting: ");
        foreach (var item in array)
        {
            Console.Write("{0} ",item);
        }
        Console.WriteLine();
    }
}