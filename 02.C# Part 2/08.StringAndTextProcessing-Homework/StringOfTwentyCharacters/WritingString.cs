using System;

//Write a program that reads from the console a string of maximum 20 characters.
//If the length of the string is less than 20, the rest of the characters should be filled with '*'.
//Print the result string into the console.

class WritingString
{
    static void Main()
    {
        string inputString = Console.ReadLine();

        if (inputString.Length <= 20)
        {
            Console.WriteLine(inputString.PadRight(20,'*'));
        }
        else
        {
            Console.WriteLine("Your input has more than 20 characters.");
        }
    }
}