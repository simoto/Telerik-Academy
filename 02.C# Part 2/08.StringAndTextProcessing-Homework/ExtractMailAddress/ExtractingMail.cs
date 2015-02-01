using System;
using System.Text;
using System.Text.RegularExpressions;

//Write a program for extracting all email addresses from given text.
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

class ExtractingMail
{
    static void Main()
    {
        string text = "Your mail is asdfgh@telerik.com using System,bgdaseg@gmail.com return";

        foreach (var item in Regex.Matches(text, @"\w+@\w+\.\w+"))
        {
            Console.WriteLine(item);
        }
    }
}
