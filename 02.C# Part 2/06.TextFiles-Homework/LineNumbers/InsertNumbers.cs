using System;
using System.IO;

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

class InsertNumbers
{
    static void Main()
    {
        StreamReader read = new StreamReader(@"..\..\someText.txt");
        StreamWriter write = new StreamWriter(@"..\..\textWithLines.txt");

        using (read)
        {
            using (write)
            {
                int line = 1;
                string lines = read.ReadLine();
                while (lines != null)
                {
                    write.WriteLine("{0}. {1}", line, lines);
                    Console.WriteLine("{0}. {1}", line, lines);
                    lines = read.ReadLine();
                    line++;
                }
            }
        }
    }
}