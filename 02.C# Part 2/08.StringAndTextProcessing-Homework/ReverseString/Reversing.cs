using System;
using System.Text;

//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

class Reversing
{
    static void Main()
    {
        Console.Write("Enter your word here: ");
        string input = Console.ReadLine();

        string output = ReverseString(input);

        Console.WriteLine("Reversed word: {0}", output);
    }

    static string ReverseString(string s)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = s.Length - 1; i >= 0; i--)
            sb.Append(s[i]);
        return sb.ToString();
    }
}