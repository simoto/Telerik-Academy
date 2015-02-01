using System;
using System.Collections.Generic;
using System.Text;

class Zergg
{
    static void Main()
    {
        string[] alphabet = { "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh" };
        List<long> converted = new List<long>();

        string message = Console.ReadLine();

        for (int i = 0; i < message.Length; i += 4)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (message.Substring(i, 4) == alphabet[j])
                {
                    converted.Add(j);
                }
            }
        }

        long result = 0;
        foreach (long number in converted)
        {
            result *= 15;
            result += number;
        }

        Console.WriteLine(result);
    }
}
