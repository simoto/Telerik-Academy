using System;
using System.Text;
using System.Threading.Tasks;

//Describe the strings in C#. What is typical for the string data type? Describe the most important methods of the String class.

class Description
{
    static void Main()
    {
        Console.WriteLine("Strings are sequences of characters");
        string str = "Hello World!"; //this is string
        char[] strArray = str.ToCharArray(); //string is sequences of characters

        Console.WriteLine("Strings are stored in the dynamic memory (managed heap)");

        Console.WriteLine("Strings have fixed length (String.Length)");
        int length = str.Length;
        Console.WriteLine("Elements can be accessed directly by index.");
        char someChar = str[6];

        Console.WriteLine("There is several ways to declare string.");
        string str1;   //first way to declare
        System.String str2; //second way to declare
        String str3; //third way to declare

        Console.WriteLine("Before initializing a string variable has null value.");
        string nullable; //this string has null value

        Console.WriteLine("String file can be read from Console.ReadLine();");

        Console.WriteLine("Two strings can be compared by operator \"==\",string.Compare,str1.Equals(str2)");

        Console.WriteLine("String also can be concatenated");
        string one = "1";
        string two = "2";
        string concatenated = one + two;

        string concatenating = String.Concat(one, two);

        Console.WriteLine("You can search in string by index (IndexOf(string str)), IndexOf(string str, int startIndex),LastIndexOf(string)");

        Console.WriteLine("Extractin substring - str.Substring(int startIndex, int length)");

        Console.WriteLine("You can Split some char arrays in string array");

        Console.WriteLine("And there is some examples of description of strings");

        //Get lenght of the string
        string text = "somestring";
        Console.WriteLine(text + " lenght -> " + text.Length);

        // Convert to uppercase.
        text = text.ToUpper();
        Console.WriteLine("ToUpper ->" + text);

        // Convert to lowercase.
        text = text.ToLower();
        Console.WriteLine("ToLower ->" + text);
        Console.WriteLine();

        //Substring -  get the first 4 characters
        Console.WriteLine("Substring - get first four characters:");
        string substring = text.Substring(0, 4);
        Console.WriteLine("Substring: {0}", substring);
        Console.WriteLine();

        //Remove leading or trailing whitespace
        string removeSpace = "  some string text  ";
        Console.WriteLine(Environment.NewLine + "Remove leading or trailing whitespace: " + "!" + removeSpace + "!");
        Console.Write("!");
        Console.Write(removeSpace.Trim());
        Console.WriteLine("!");

        //Split string
        string stringSample = "This is an example for string split";
        Console.WriteLine(Environment.NewLine + "Split string on spaces.This will separate all words of the string.");

        string[] words = stringSample.Split(' ');
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        //IndexOf method - one of the searching methods
        Console.WriteLine(Environment.NewLine + "IndexOf method:");
        if (stringSample.IndexOf("example") != -1)
        {
            Console.Write("string contains 'example'");
        }
        Console.WriteLine();

        //Copy string
        Console.WriteLine(Environment.NewLine + "Copy a literal string");

        string sample = "This is a string";
        string copySample = string.Copy(sample);

        Console.WriteLine("First string: ");
        Console.WriteLine(sample);
        Console.WriteLine("Second string: ");
        Console.WriteLine(copySample);
        // See if the references are equal.
        Console.WriteLine("Are two strings Equal?: " + object.ReferenceEquals(sample, copySample));
        Console.WriteLine("That is because the object data is equivalent in both objects, but the data ");
        Console.WriteLine("is not in the same storage location and the references are unequal.");

        //Concatenation
        Console.WriteLine(Environment.NewLine + "Concatenation of strings:");
        sample = string.Concat(sample, " and ", copySample);
        Console.WriteLine(sample);

        //Replace
        Console.WriteLine(Environment.NewLine + "Replace text in string:");
        string replace = copySample.Replace("This", "That");
        Console.WriteLine(replace);
        Console.WriteLine();

        //Append
        Console.WriteLine(Environment.NewLine + "Append the word \"NEW\" to the previous string.");
        copySample += " NEW";
        Console.WriteLine(copySample);

        //Compare strings
        string first = "First string";
        string second = "Second string";
        Console.WriteLine(Environment.NewLine + "Compare strings: " + first + ", " + second);
        Console.WriteLine("If the first string is bigger, the result is 1. If the first string is smaller, the result is -1.");
        Console.WriteLine("If both strings are equal, the result is 0. The number essentially indicates how much larger the first string is.");
    }
}