using System;
using System.Text.RegularExpressions;

//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

class Palindromes
{
    static void Main()
    {
        string str = "There is my text ABBA, my word is lamal and I have one exe.";

        foreach (Match item in Regex.Matches(str, @"\w+"))
        {
            if (IsPalindrome(item.Value))
            {
                Console.WriteLine(item);
            }
        }
    }

    static bool IsPalindrome(string word)
    {
        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}