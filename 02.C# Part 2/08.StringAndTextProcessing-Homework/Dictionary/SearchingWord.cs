using System;
using System.Collections.Generic;

//A dictionary is stored as a sequence of text lines containing words and their explanations. 
//Write a program that enters a word and translates it by using the dictionary.

class SearchingWord
{
    static void Main(string[] args)
    {
        string[] words = { ".NET", "CLR", "namespace" };

        string[] descript = { "platform for applications from Microsoft", "managed execution environment for .NET",
        "hierarchical organization of classes" };

        Console.Write("Enter word: ");
        string input = Console.ReadLine();

        for (int i = 0; i < words.Length; i++)
        {
            if (input == words[i])
            {
                Console.WriteLine("{0} - {1}", words[i], descript[i]);
            }
        }
    }
}

