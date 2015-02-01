using System;
using System.IO;

//Write a program that concatenates two text files into another text file.

class ConcatenateTwoFiles
{
    static void Main()
    {
        StreamReader readerOne = new StreamReader("../../fileOne.txt");
        StreamReader readerTwo = new StreamReader("../../fileTwo.txt");
        StreamWriter writer = new StreamWriter("../../concatenated.txt");

        using (readerOne)
        {
            using (readerTwo)
            {
                using (writer)
                {
                    string textOne = readerOne.ReadToEnd();
                    string textTwo = readerTwo.ReadToEnd();
                    writer.Write(textOne + "\r\n" + textTwo);
                }
            }
        }

        StreamReader concatenate = new StreamReader("../../concatenated.txt");

        using (concatenate)
        {
            string read = concatenate.ReadToEnd();
            Console.WriteLine(read);
        }       
    }
}