using System;
using System.Globalization;

//Write a program that reads a date and time given in the format:
//day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes 
//(in the same format) along with the day of week in Bulgarian.

class ReadingDate
{
    static void Main()
    {
        Console.Write("Enter data and time (dd.MM.yyyy HH:mm:ss): ");
        string dateAndTime = Console.ReadLine();

        DateTime date = DateTime.ParseExact(dateAndTime, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        date = date.AddMinutes(30);
        date = date.AddHours(6);

        Console.WriteLine("{0} {1}", date.ToString("dddd", new CultureInfo("bg-BG")), date.ToString(new CultureInfo("bg-BG")));
    }
}
