using System;
using System.Linq;

//You are given an array of strings. Write a method that sorts the array
//by the length of its elements (the number of characters composing them).

class SortLength
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int arrlength = int.Parse(Console.ReadLine());
        string[] unsortedStrings = new string[arrlength];

        for (int i = 0; i < unsortedStrings.Length; i++)
        {
            Console.Write("Enter string index {0}: ", i);
            unsortedStrings[i] = Console.ReadLine();
        }

        foreach (var item in unsortedStrings.OrderBy(uStrings => uStrings.Length))
        {
            Console.WriteLine(item);
        }
    }
}
