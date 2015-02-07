using System.Collections.Generic;
using System.Linq;
using System;

//Write a program that sorts an array of integers using the Merge sort algorithm.

class MergeSort
{
    static void Main()
    {
        List<int> firstArray = new List<int>() { 1, 4, 15, 2, 36, 54, 3, 53, 43, 8 };

        Console.WriteLine(string.Join(", ", MergeSortImplementation(firstArray)));
    }

    static List<int> MergeSortImplementation(List<int> array)
    {
        if (array.Count <= 1)
        {
            return array;
        }
        
        List<int> left, right;

        int middle = array.Count / 2;
        left = new List<int>();

        for (int i = 0; i < middle; i++)
		{
			 left.Add(array[i]);
	    }

        right = new List<int>();

        for (int i = middle; i < array.Count; i++)
		{
			 right.Add(array[i]);
	    }

        left = MergeSortImplementation(left);
        right = MergeSortImplementation(right);

        return Merge(left, right);
    }
    
    static List<int> Merge(List<int> left, List<int> right)
    {
        List<int> result = new List<int>();

        while(left.Count > 0 && right.Count > 0)
        {
            if (left.First() <= right.First())
	        {
		        result.Add(left.First());
                left.Remove(left.First());
	        }
            else
	        {
                result.Add(right.First());
                right.Remove(right.First());
	        }
        }

        while (left.Count > 0)
	    {
	         result.Add(left.First());
             left.Remove(left.First());
        }

        while (right.Count > 0)
        {
            result.Add(right.First());
            right.Remove(right.First());
        }

        return result;
    }  
}