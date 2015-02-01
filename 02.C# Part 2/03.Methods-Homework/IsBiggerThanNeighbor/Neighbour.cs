using System;

//Write a method that checks if the element at given position in given array of integers
//is bigger than its two neighbors (when such exist).

class Neighbour
{
    static bool IsBigger(int position, int[] array)
    {
        if (position == 0 || position == array.Length - 1)
        {
            return false;
        }
        else if (array[position] > array[position - 1] && array[position] > array[position + 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 4, 3, 2, 1 };
        Console.WriteLine("Enter position: ");
        int pos = int.Parse(Console.ReadLine());

        Console.Write("Is bigger than neighbours: ");
        Console.WriteLine(IsBigger(pos, arr));
    }
}