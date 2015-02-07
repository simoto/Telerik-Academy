using System;

//Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.

class IndexOfLetters
{
    static void Main()
    {
        char[] englishAlphabet = new char[26];

        for (int i = 'A', index = 0; i < 'Z'; i++, index++)
        {
            englishAlphabet[index] = (char)i;
        }

        Console.Write("Enter a word: ");
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < englishAlphabet.Length; j++)
            {
                if (char.ToUpper(input[i]) == englishAlphabet[j])
                {
                    Console.WriteLine("The letter {0} has index of {1}", input[i], j);
                }
            }
        }
    }
}