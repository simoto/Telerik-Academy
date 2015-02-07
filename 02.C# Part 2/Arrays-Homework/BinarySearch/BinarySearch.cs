using System;
using System.Collections.Generic;

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

class BinarySearch
{
    static void Main()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 14, 65, 100 };

        Console.WriteLine("The element is found at index {0}", BinarySearchImplementation(array, 14, 1, 8));
    }

    static int BinarySearchImplementation(int[] array, int key, int iMin, int iMax)
    {
        while (iMax >= iMin)
        {
            int iMid = MidPoint(iMin, iMax);
            if (array[iMid] == key)
            {
                return iMid; 
            }
            else if (array[iMid] < key)
            {
                iMin = iMid + 1;
            }
            else
            {
                iMax = iMid - 1;
            }            
        }
  
        throw new KeyNotFoundException();
    }

    static int MidPoint(int min, int max)
    {
        return min + ((max - min) / 2);
    }
}
