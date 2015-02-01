using System;
using System.IO;

//Write a program that reads a text file and prints on the console its odd lines.

class OddLines
{
    static void Main()
    {
        StreamReader read = new StreamReader(@"..\..\textForFirstExercise.txt");

        using (read)
        {
            int line = 1;
            string lines = read.ReadLine();
            while (lines != null)
            {
                if (line % 2 != 0)
                {
                    Console.WriteLine("Line {0}: {1}", line,lines);
                }
                lines = read.ReadLine();
                line++;
            }
        }
    }
}