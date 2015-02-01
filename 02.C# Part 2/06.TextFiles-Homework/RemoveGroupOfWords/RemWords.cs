using System;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

class RemWords
{
    static void Main()
    {
        string words = @"\b(" + String.Join("|", File.ReadAllLines("../../words.txt")) + @")\b";

        using (StreamReader input = new StreamReader("../../input.txt"))
        {
            using (StreamWriter output = new StreamWriter("../../output.txt"))
            {
                for (string line; (line = input.ReadLine()) != null; )
                {
                    output.WriteLine(Regex.Replace(line, words, String.Empty));
                }
            }
        }

        Console.WriteLine("Operation is Done!");
    }
}
