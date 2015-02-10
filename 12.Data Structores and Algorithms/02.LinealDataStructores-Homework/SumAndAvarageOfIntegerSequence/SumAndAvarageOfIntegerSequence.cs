namespace SumAndAvarageOfIntegerSequence
{
    using System;
    using System.Collections.Generic;

    /* Write a program that reads from the console a sequence of positive integer numbers.
    The sequence ends when empty line is entered. Calculate and print the sum and average of the elements of the sequence. 
    Keep the sequence in List<int>.
     */

    class SumAndAvarageOfIntegerSequence
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

            long sum = 0;

            foreach (var number in sequence)
            {
                sum += number;
            }

            Console.WriteLine("Sum of these numbers is: " + sum);
            Console.WriteLine("Avarage of these numbers is: {0}", sum / sequence.Count);
        }
    }
}
