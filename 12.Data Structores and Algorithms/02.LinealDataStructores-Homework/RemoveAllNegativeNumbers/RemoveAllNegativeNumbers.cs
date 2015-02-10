namespace RemoveAllNegativeNumbers
{
    using System;
    using System.Collections.Generic;

    //Write a program that removes from given sequence all negative numbers.

    class RemoveAllNegativeNumbers
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

            sequence.RemoveAll(x => x < 0);

            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
