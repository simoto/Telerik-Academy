namespace LongestSubsequence
{
    using System;
    using System.Collections.Generic;

  //  Write a method that finds the longest subsequence of equal numbers in given List<int> and returns the result as new List<int>.
   // Write a program to test whether the method works correctly.

    class LongestSubsequence
    {
        static void Main()
        {
            List<int> sequence = new List<int>();

            string input = Console.ReadLine();
            int inputAsNumber;

            while (input != String.Empty)
            {
                inputAsNumber = int.Parse(input);
                sequence.Add(inputAsNumber);
                input = Console.ReadLine();
            }

            FindLongestSubsequence(sequence);
        }

        static void FindLongestSubsequence(IList<int> list)
        {
            int currentNumber = list[0];
            int longestSequence = 0;

            int bestNumber = list[0];
            int bestSequence = 0;

            foreach (var number in list)
            {
                if (number == currentNumber)
                {
                    longestSequence++;
                }
                else
                {
                    if (longestSequence > bestSequence)
                    {
                        bestSequence = longestSequence;
                        bestNumber = currentNumber;
                    }
                    currentNumber = number;
                    longestSequence = 1;
                }
            }

            Console.WriteLine("Best sequence is {0} with number {1}", bestSequence, bestNumber);
        }
    }
}
