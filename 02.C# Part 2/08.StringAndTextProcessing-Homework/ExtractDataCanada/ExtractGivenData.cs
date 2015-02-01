using System;
using System.Globalization;
using System.Text.RegularExpressions;

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

class ExtractGivenData
{
    static void Main()
    {
        string str = "asd 10.10.2012, 20.11.2011 asd";

        DateTime date;
        foreach (Match item in Regex.Matches(str, @"\b\d{2}.\d{2}.\d{4}\b"))
        {
            date = DateTime.ParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
        }
    }
}
