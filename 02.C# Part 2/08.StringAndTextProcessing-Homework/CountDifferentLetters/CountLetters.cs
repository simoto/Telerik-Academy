using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads a string from the console and prints all different letters
//in the string along with information how many times each letter is found. 

class CountLetters
{
    static void Main()
    {

        Console.Write("Enter text here: ");
        string input = Console.ReadLine();

        string[] specialSigns = { " ", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "0", "1", "2", "3", "4",
                                "5", "6", "7", "8", "9"};

        for (int i = 0; i < specialSigns.Length; i++)
        {
            input = input.Replace(specialSigns[i], string.Empty);
        }

        Dictionary<char, int> allLetters = new Dictionary<char, int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (allLetters.ContainsKey(input[i]))
            {
                allLetters[input[i]]++;
            }
            else
            {
                allLetters.Add(input[i], 1);
            }
        }

        var sortedLetters = allLetters.OrderBy(x => x.Key);
        foreach (var item in sortedLetters)
        {
            Console.WriteLine("Letter --> {0} - Number --> {1}", item.Key, item.Value);
        }
    }
}