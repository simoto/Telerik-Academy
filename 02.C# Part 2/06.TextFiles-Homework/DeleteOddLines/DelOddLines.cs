using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

//Write a program that deletes from given text file all odd lines. The result should be in the same file.

class DelOddLines
{
    static void Main()
    {
        StreamReader read = new StreamReader(@"..\..\inputfile.txt", Encoding.GetEncoding(1251));
        
        List<string> even = new List<string>();

        using (read)
        {
            int line = 1;
            string lines = read.ReadLine();
            while (lines != null)
            {
                if (line % 2 == 0)
                {
                    even.Add(lines);
                }
                lines = read.ReadLine();
                line++;
            }
        }

        StreamWriter deleteOdd = new StreamWriter(@"..\..\inputfile.txt",false, Encoding.GetEncoding(1251));

        using (deleteOdd)
        {
            for (int i = 0; i < even.Count; i++)
            {
                deleteOdd.WriteLine(even[i]);
            }
        }
    }
}