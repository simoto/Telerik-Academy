using System;

//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//        x2 + 5 = 1x2 + 0x + 5  501

class PolynomialMethod
{
    static void PrintPolynom(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + "x^" + i + (i == 0 ? "\n" : " + "));
        }
    }

    static int[] Add(int[] firstPolinom, int[] secondPolinom)
    {
        if (firstPolinom.Length > secondPolinom.Length)
        {
            return Add(secondPolinom, firstPolinom); // a <= b
        }

        PrintPolynom(firstPolinom);
        PrintPolynom(secondPolinom);

        int[] result = new int[secondPolinom.Length];

        int i = 0;

        for (; i < firstPolinom.Length; i++)
        {
            result[i] = firstPolinom[i] + secondPolinom[i];
        }

        for (; i < secondPolinom.Length; i++)
        {
            result[i] = secondPolinom[i];
        }

        return result;
    }

    static void Main()
    {
        int[] firstArray = { 2, 4, 5, 1 };
        int[] secondArray = { 1, 2, 5, 4, 2 };

        PrintPolynom(Add(firstArray, secondArray));
        Console.WriteLine();
    }
}