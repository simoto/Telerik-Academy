using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

//  Write a program that reverses the words in given sentence.
//Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

class Reversing
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";

        string regex = @"\s+|,\s*|\.\s*|!\s*|$";

        var words = new Stack<string>();

        foreach (var word in Regex.Split(text, regex))
        {
            if (!String.IsNullOrEmpty(word))
            {
                words.Push(word);
            }
        }

        foreach (var separator in Regex.Matches(text, regex))
        {
            Console.Write(words.Pop() + separator);

            if (words.Count == 0)
            {
                break;
            }
        }

        Console.WriteLine();
    }
}
