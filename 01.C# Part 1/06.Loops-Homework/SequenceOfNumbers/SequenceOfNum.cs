using System;
//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

class SequenceOfNum
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want to write: ");
        byte numbers = byte.Parse(Console.ReadLine());

        int minNum = int.MaxValue;
        int maxNum = int.MinValue;
        for (int i = 0; i < numbers; i++)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            if (num > maxNum)
            {
                maxNum = num;
            }

            if (num < minNum)
            {
                minNum = num;
            }
        }
        Console.WriteLine("The smallest number is {0}", minNum);
        Console.WriteLine("The greatest number is {0}", maxNum);
    }
}

