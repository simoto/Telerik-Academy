using System;
/* Write a program that reads a number N and calculates the sum of the first N members 
of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, … */

class SumOfNMembers
{
    static void Main()
    {
        Console.Write("N= ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int firstNum = 0;
        int secondNum = 1;
        int current = 0;
        for (int i = 0; i < n - 2; i++)
        {
            current = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = current;
            sum += current;
        }

        Console.WriteLine("The sum of numbers is : {0}", (1 + sum));
    }
}
