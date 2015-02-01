using System;

//Extend the program to support also subtraction and multiplication of polynomials.

class PolynomialSubAndMultiply
{
    static void PrintPolynom(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + "x^" + i + (i == 0 ? "\n" : " + "));
        }
    }

    static int[] Subtract(int[] a, int[] b, bool reversed = false)
    {
        if (a.Length > b.Length)
        {
            return Subtract(b, a, reversed: true); //a <= b
        }
        PrintPolynom(a);
        PrintPolynom(b);

        int[] result = new int[b.Length];

        int i = 0;

        for (; i < a.Length; i++)
        {
            // For each digit in arrays
            result[i] = (reversed ? b[i] - a[i] : a[i] - b[i]);
        }

        for (; i < b.Length; i++)
        {
            // If the array has digits left
            result[i] = (reversed ? b[i] : -b[i]);
        }
        return result;
    }

    public static int[] Multiply(int[] a, int[] b)
    {
        PrintPolynom(a);
        PrintPolynom(b);

        int[] result = new int[a.Length + b.Length - 1];

        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < b.Length; j++)
            {
                result[i + j] += a[i] * b[j];
            }
        }

        return result;
    }

    static void Main()
    {       
        int[] firstArray = { 2, 4 , 5 ,1};
        int[] secondArray = { 1, 2, 5, 4, 2};

        PrintPolynom(Subtract(firstArray, secondArray));
        Console.WriteLine();

        PrintPolynom(Multiply(firstArray, secondArray));
        Console.WriteLine();
    }
}