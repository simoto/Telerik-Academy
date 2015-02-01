using System;
using System.IO;

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
//Be sure to catch all possible exceptions and print user-friendly error messages.

class ReadFileFromPath
{
    static void Main()
    {
        try
        {
            string path = @"C:\WINDOWS\win.ini";                      
           Console.WriteLine(File.ReadAllText(path)); 
           
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid path or file not found.");
        }
    }
}