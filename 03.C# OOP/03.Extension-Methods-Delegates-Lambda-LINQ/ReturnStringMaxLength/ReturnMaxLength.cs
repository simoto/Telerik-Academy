//Write a program to return the string with maximum length from an array of strings. Use LINQ.

namespace ReturnStringMaxLength
{
    using System;
    using System.Linq;

    class ReturnMaxLength
    {
        static void Main()
        {
            string[] strArr = new string[] { "sample", "words", "here", "the most", "largest" };

            var largeWord = strArr.Aggregate((max, current) => max.Length > current.Length ? max : current);

            Console.WriteLine("The largest word is: {0}", largeWord);
        }
    }
}