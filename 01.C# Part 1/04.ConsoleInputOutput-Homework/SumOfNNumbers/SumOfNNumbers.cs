//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want to sum: ");
        int n = int.Parse(Console.ReadLine());

        long result = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            int currentNumber = int.Parse(Console.ReadLine());
            result += currentNumber;
        }

        Console.WriteLine("The sum of these numbers is {0}", result);
    }
}

