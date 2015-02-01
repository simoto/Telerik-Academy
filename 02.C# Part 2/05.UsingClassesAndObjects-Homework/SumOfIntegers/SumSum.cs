using System;

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum. Example:
//        string = "43 68 9 23 318"  result = 461

class SumSum
{
    static void Main()
    {
        Console.Write("Enter sequence of numbers with space between integers: ");
        string givenStr = Console.ReadLine();
        Console.WriteLine("The result ot their's sum is: {0}.", SumString(givenStr));
    }

    static int SumString(string input)
    {
        int sum = 0;
        string[] integers = input.Split(' ');

        for (int i = 0; i < integers.Length; i++)
        {
            sum += int.Parse(integers[i]);
        }

        return sum;
    }
}