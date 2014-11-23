//Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;

class FibonacciSequence
{
    static void Main()
    {
        int firstNumber = 0;
        int secondNumber = 1;
        int nextNumber = firstNumber + secondNumber;
        Console.Write(firstNumber + ", ");
        Console.Write(secondNumber + ", ");
        Console.Write(nextNumber + ", ");

        for (int i = 3; i <= 100; i++)
        {
            firstNumber = secondNumber;
            secondNumber = nextNumber;
            nextNumber = firstNumber + secondNumber;
            Console.Write(nextNumber + ", ");
        }
    }
}
