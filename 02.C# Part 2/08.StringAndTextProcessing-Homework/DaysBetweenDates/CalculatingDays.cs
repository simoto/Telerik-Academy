using System;
using System.Globalization;

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 

class CalculatingDays
{
    static void Main()
    {
        Console.Write("Enter the first date: ");
        string firstDate = Console.ReadLine();
        Console.Write("Enter the second date: ");
        string secondDate = Console.ReadLine();

        DateTime startDate = DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Distance: {0}",(endDate - startDate).TotalDays);     
    }
}