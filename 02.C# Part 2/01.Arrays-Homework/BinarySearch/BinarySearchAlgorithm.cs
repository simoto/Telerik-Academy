using System;

// Write a program that finds the index of given element in a sorted array of integers by using the binary 
// search algorithm (find it in Wikipedia).

class BinarySearchAlgorithm
{
    static void Main()
    {
        Console.WriteLine("You must enter sorted elements!");
        Console.Write("Enter array length: ");
        int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];

        for (int i = 0; i < number; i++)
        {
            Console.Write("Enter Value for {0} element: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter wanted number: ");
        int wanted = int.Parse(Console.ReadLine());

        //binary search
        int low = 0;
        int middle = 0;
        int high = array.Length - 1;

        while (low <= high)
        {
            middle = low + (high - low) / 2;

            if (wanted == array[middle])
            {
                Console.WriteLine("Found element is with index {0} ",middle);
                return;
            }
            else if (wanted < array[middle])
            {
                high = middle - 1;
            }
            else
            {
                low = middle + 1;
            }            
        }

        Console.WriteLine("Item was not found.");
    }
}