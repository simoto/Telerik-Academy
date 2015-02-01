using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads a string from the console and replaces all series of consecutive
//identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

class ReplaceLetters
{
    static void Main()
    {
        Console.Write("Enter text here: ");
        string input = Console.ReadLine();

        List<char> list = new List<char>();
        list.Add(input[0]);
        for (int i = 1,start = 0; i < input.Length; i++)
        {
            if (input[start] == input[i])
            {
                continue;
            }
            else
            {
                list.Add(input[i]);
                start = i;
            }
        }
       
        Console.Write("The result is: ");

        foreach (var item in list)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}