using System;
using System.Collections.Generic;
using System.Linq;

class OddNumberOfTime
{
    public static void Main(string[] args)
    {
        string[] elements = { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
        PrintOddOccurences(elements);
    }

    public static void PrintOddOccurences(string[] elements)
    {
        Dictionary<string, int> occurences = new Dictionary<string, int>();

        foreach (var element in elements)
        {
            if (!occurences.ContainsKey(element))
            {
                occurences.Add(element, 0);
            }

            occurences[element]++;
        }

        var oddOccurences = occurences.Where(x => x.Value % 2 == 1);

        foreach (var occurence in oddOccurences)
        {
            Console.WriteLine("{0} -> {1} times", occurence.Key, occurence.Value);
        }
    }
}
