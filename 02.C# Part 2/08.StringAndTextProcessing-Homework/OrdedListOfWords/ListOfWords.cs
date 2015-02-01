using System;
using System.Collections.Generic;

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

class ListOfWords
{
    static void Main()
    {
        Console.Write("Enter list of word: ");
        string input = Console.ReadLine();

        string[] list = input.Split(' ');

        Array.Sort(list);

        Console.Write("Sorted: ");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();        
    }
}
