using System;
using System.Collections.Generic;

 /* Write a method that adds two positive integer numbers represented as arrays of digits 
    (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
    Each of the numbers that will be added could have up to 10 000 digits.
  */

class PositiveArray
{
    static byte[] Add(byte[] a, byte[] b)
    {
        if (a.Length > b.Length) return Add(b, a); 

        PrintNum(a);
        PrintNum(b);

        byte[] result = new byte[b.Length + 1]; 

        int i = 0, carry = 0;

        for (; i < a.Length; i++)
        {
            result[i] = (byte)(a[i] + b[i] + carry);

            carry = result[i] / 10;
            result[i] %= 10;
        }

        for (; i < b.Length && carry != 0; i++)
        {
            result[i] = (byte)(b[i] + carry);

            carry = result[i] / 10;
            result[i] %= 10;
        }

        for (; i < b.Length; i++)
        {
            result[i] = b[i];
        }

        if (carry != 0) result[i] = 1;
        else Array.Resize(ref result, result.Length - 1);

        return result;
    }

    static void PrintNum(byte[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--) Console.Write(arr[i]); // Reversed

        Console.WriteLine();
    }

    static void Main()
    {
        byte[] integerOne = { 4, 5, 6 };
        byte[] integerTwo = { 3, 2, 7 };

        PrintNum(Add(integerOne, integerTwo));
    }
}