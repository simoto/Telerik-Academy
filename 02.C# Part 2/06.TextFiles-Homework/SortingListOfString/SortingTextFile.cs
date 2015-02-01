using System;
using System.Collections.Generic;
using System.IO;

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 

class SortingTextFile
{
    static void Main()
    {
        StreamReader input = new StreamReader("../../names.txt");
        StreamWriter output = new StreamWriter("../../output.txt");
        List<string> list = new List<string>();

        using (input)
        {
            string singleName = input.ReadLine();
            while (singleName != null)
            {
                list.Add(singleName);
                singleName = input.ReadLine();                
            }
        }

        list.Sort();

        using (output)
        {
            for (int i = 0; i < list.Count; i++)
            {
                output.WriteLine(list[i]);
            }
        }

        Console.WriteLine("Output File is Sorted!");
    }
}