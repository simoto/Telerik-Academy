//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class GreaterNumber
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int greater = (firstNumber > secondNumber) ? firstNumber : secondNumber;

        Console.WriteLine("The greater number is: {0}", greater);
    }
}
