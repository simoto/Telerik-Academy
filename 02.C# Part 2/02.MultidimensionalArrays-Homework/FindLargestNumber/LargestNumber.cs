using System;

//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

class LargestNumber
{
    static int LowerBound(int[] arr, int x)
    {
        int l = 0, r = arr.Length - 1;

        while (l < r)
        {
            int m = l + (r - l + 1) / 2;

            if (arr[m] > x) r = m - 1;
            else l = m;
        }

        if (arr[l] > x) l--;

        return l;
    }

    static void Main()
    {
        Console.Write("Enter array length: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter number K: ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter number for array with index {0}: ",i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        int result = LowerBound(array, k);

        Console.WriteLine(result);
    }
}