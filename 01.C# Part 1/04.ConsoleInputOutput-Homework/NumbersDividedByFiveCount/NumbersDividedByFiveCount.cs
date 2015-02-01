﻿ /*Write a program that reads two positive integer numbers and prints 
how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.
*/

using System;

class NumbersDividedByFiveCount
{
    static void Main()
    {
        Console.Write("Enter the first positive number: ");
        uint firstNumber = uint.Parse(Console.ReadLine());
        Console.Write("Enter the second positive number: ");
        uint secondNumber = uint.Parse(Console.ReadLine());

        int divisibleCount = 0;

        for (uint i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                divisibleCount++;
            }
        }

        Console.WriteLine("{0} numbers", divisibleCount);
    }
}
