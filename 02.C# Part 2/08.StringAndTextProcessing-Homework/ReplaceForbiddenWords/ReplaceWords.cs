﻿using System;

//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.

class ReplaceWords
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        string replaced = text.Replace("PHP", "***").Replace("CLR", "***").Replace("Microsoft", "*********");

        Console.WriteLine(replaced);
    }
}