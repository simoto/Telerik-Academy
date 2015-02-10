namespace SortSimpleList
{
    using System;
    using System.Collections.Generic;

    //Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.

    class SortSimpleList
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

            sequence.Sort();

            foreach (var item in sequence)
            {
                Console.WriteLine(item);
            }
        }
    }
}
