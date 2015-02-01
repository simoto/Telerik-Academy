using System;

//Write a program that reads two arrays from the console and compares them element by element.

class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter the length for arrays: ");
        int arrLength = int.Parse(Console.ReadLine());        

        int[] firstArr = new int[arrLength];
        int[] secondArr = new int[arrLength];

        //reading of first array
        for (int i = 0; i < firstArr.Length; i++)
        {
            Console.Write("Enter value for first array element with index {0}: ",i);
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        //reading of second array
        for (int i = 0; i < secondArr.Length; i++)
        {
            Console.Write("Enter value for second array element with index {0}: ", i);
            secondArr[i] = int.Parse(Console.ReadLine());
        }

        //comparate
        bool isEqual = true;
        for (int i = 0; i < arrLength; i++)
        {
            isEqual = true;

            if (firstArr[i] == secondArr[i])
            {
                Console.WriteLine("Elements {0} is equal: {1}", i, isEqual);
            }
            else if (firstArr[i] != secondArr[i])
            {
                isEqual = false;
                Console.WriteLine("Elements {0} is equal: {1}", i, isEqual);
            }
        }
    }
}