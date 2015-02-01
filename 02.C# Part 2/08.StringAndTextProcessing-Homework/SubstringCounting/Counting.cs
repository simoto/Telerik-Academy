using System;
using System.Text.RegularExpressions;

//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

class Counting
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else.Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string subStr = "in";

        Console.WriteLine(Regex.Matches(text, subStr, RegexOptions.IgnoreCase).Count);
    }
}
