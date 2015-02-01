using System;
using System.Text;

//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 

class ConvertingToUnicodeSymbols
{
    static void Main()
    {
        Console.Write("Enter word here: ");
        string text = Console.ReadLine();

        Console.WriteLine(ConvertToUnicode(text));          
    }

    static string ConvertToUnicode(string a)
    {
        StringBuilder utf = new StringBuilder();

        foreach (char c in a)
        {
            utf.AppendFormat(@"\u{0:X4}", (int)c);
        }

        return utf.ToString();
    }
}
