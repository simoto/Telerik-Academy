using System;

// Write a program that creates an array containing all letters from the alphabet (A-Z). 
// Read a word from the console and print the index of each of its letters in the array.

class Alphabet
{
    static void Main()
    {
        char[] characterArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
                                    'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        Console.Write("Enter your word: ");
        string word = Console.ReadLine();
        word = word.ToLower();

        char[] characters = word.ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
            for (int j = 0; j < characterArray.Length; j++)
            {
                if (characterArray[j] == characters[i])
                {
                    Console.WriteLine("Character {0} is with index {1}",characters[i],j);
                    break;
                }
            }
        }
    }
}