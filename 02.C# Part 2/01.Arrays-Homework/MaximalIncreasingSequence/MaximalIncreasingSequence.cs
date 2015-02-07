using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the maximal increasing sequence in an array.

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter an array foreach element separated by \",\": ");
        string input = Console.ReadLine();
        string[] sequence = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        int currentElement = int.Parse(sequence[0]);
        int nextElement;
        int bestSequence = 1;
        int currentSequence = 1;
        int currentStartIndex = 0;
        int currentEndIndex = 0;
        int bestSequenceStartIndex = 0;
        int bestSequenceEndIndex = 0;

        for (int i = 1; i < sequence.Length; i++)
        {
            nextElement = int.Parse(sequence[i]);
            if (nextElement > currentElement)
            {
                currentEndIndex++;
                currentSequence++;
            }
            else
            {
                if (currentSequence > bestSequence)
                {
                    bestSequence = currentSequence;
                    bestSequenceStartIndex = currentStartIndex;
                    bestSequenceEndIndex = currentEndIndex;
                }
                else
                {
                    currentSequence = 1;
                    currentStartIndex = i;
                    currentEndIndex = i;
                    currentElement = nextElement;
                }               
            }
        }

        Console.WriteLine(string.Join(", ", sequence.Skip(bestSequenceStartIndex).Take(bestSequence).ToArray()));
    }
}
    