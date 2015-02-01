using System;

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is working correctly.

class SameNumber
{
    static int CountSameNumber(int a, int[] b)
    {
        int count = 0;
        foreach (int num in b)
        {
            if (a == num)
            {
                count++;
            }
        }

        return count;
    }

    static void Main()
    {        
        Console.Write("Enter the number you want: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter array length: ");
        int arrLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrLength];

        for (int i = 0; i < arrLength; i++)
        {
            Console.Write("Enter value for element with index {0}: ",i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int count = CountSameNumber(number, array);
        Console.WriteLine(count);
    }
}