//Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class ThreeNumbersSum
{
    static void Main()
    {
        Console.Write("Enter the first integer: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second integer: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the third integer: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.Write("The sum of these three numbers is: {0}", firstNumber + secondNumber + thirdNumber);
    }
}

