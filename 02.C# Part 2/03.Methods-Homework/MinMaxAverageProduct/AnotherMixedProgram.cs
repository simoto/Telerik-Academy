using System;

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

class AnotherMixedProgram
{
    static void Main()
    {
        int[] array = { 2, 3, 4, 6, 8, 34, 12 };

        Console.WriteLine("Minimal number: {0}", Minimum(array));
        Console.WriteLine("Maximal number: {0}", Maximum(array));
        Console.WriteLine("Sum: {0}", SumOfArray(array));
        Console.WriteLine("Average: {0}", Average(array));
        Console.WriteLine("Product: {0}", Product(array));
    }

    static int Minimum(params int[] arr)
    {
        Array.Sort(arr);
        return arr[0];
    }

    static int Maximum(params int[] arr)
    {
        Array.Sort(arr);
        return arr[arr.Length - 1];
    }

    static int SumOfArray(params int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum;
    }

    static decimal Average(params int[] arr)
    {
        decimal sum = SumOfArray(arr);
        sum /= arr.Length;

        return sum;
    }

    static decimal Product(params int[] arr)
    {
        decimal product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }

        return product;
    }
}