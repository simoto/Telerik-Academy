using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Write a program that reads a string from the console and lists all different words
//in the string along with information how many times each word is found.

class CountingWords
{
    static void Main()
    {
        Console.Write("Enter text here: ");
        string input = Console.ReadLine();

        string[] specialSigns = { " ", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "0", "1", "2", "3", "4",
                                "5", "6", "7", "8", "9"};

        for (int i = 0; i < specialSigns.Length; i++)
        {
            input = input.Replace(specialSigns[i], " ");
        }

        Dictionary<string, int> allWords = new Dictionary<string, int>();

        foreach (Match word in Regex.Matches(input, @"\w+"))
        {
            allWords[word.Value] = allWords.ContainsKey(word.Value) ? allWords[word.Value] + 1 : 1;
        }

        foreach (var pair in allWords)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }
}