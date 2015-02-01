using System;
using System.IO;

//Write a program that compares two text files line by line and prints
//the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

class CompareTextLines
{
    static void Main()
    {
        StreamReader readFile1 = new StreamReader(@"..\..\text1.txt");
        StreamReader readFile2 = new StreamReader(@"..\..\text2.txt");

        using (readFile2)
        {
            using (readFile1)
            {
                int equals = 0;
                int difference = 0;
                string lineFile1 = readFile1.ReadLine();
                string lineFile2 = readFile2.ReadLine();

                while (lineFile1 != null && lineFile2 != null)
                {
                    if (lineFile1.Equals(lineFile2))
                    {
                        equals++;
                    }
                    else
                    {
                        difference++;
                    }
                    lineFile1 = readFile1.ReadLine();
                    lineFile2 = readFile2.ReadLine();
                }

                Console.WriteLine("Equal lines: {0}", equals);
                Console.WriteLine("Different lines: {0}", difference);
            }
        }
    }
}