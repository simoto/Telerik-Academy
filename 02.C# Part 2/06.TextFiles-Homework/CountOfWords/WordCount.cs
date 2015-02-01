using System;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that reads a list of words from a file words.txt
//and finds how many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by 
//the number of their occurrences in descending order. Handle all possible exceptions in your methods.

class WordCount
{
    static void Main()
    {
        string[] words = File.ReadAllLines("../../words.txt");
        int[] values = new int[words.Length];

        using (StreamReader input = new StreamReader("../../input.txt"))
        {
            for (string line; (line = input.ReadLine()) != null; )
            {
                for (int i = 0; i < words.Length; i++)
                {
                    values[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;
                }
            }
        }

        Array.Sort(values, words);

        using (StreamWriter output = new StreamWriter("../../output.txt"))
        {
            for (int i = words.Length - 1; i >= 0; i--)
            {
                output.WriteLine("{0}: {1}", words[i], values[i]);
            }
        }

        Console.WriteLine("Operation is Done!");
    }
}
