using System;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that deletes from a text file all words that start with the prefix "test".
//Words contain only the symbols 0...9, a...z, A…Z, _.

class DeleteWordStart
{
    static void Main()
    {
        StreamReader input = new StreamReader("../../input.txt");
        StreamWriter output = new StreamWriter("../../output.txt");

        using (input)
        {
            using (output)
            {
                for (string line; (line = input.ReadLine()) != null; )
                {
                    output.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
                }
            }
        }

        Console.WriteLine("Operation is Done!");
    }
}