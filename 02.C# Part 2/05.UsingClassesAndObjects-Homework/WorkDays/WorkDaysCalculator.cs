using System;

//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

class WorkDaysCalculator
{
    static void Main()
    {
        Console.Write("Enter your end data here(yyyy mm dd): ");
        string[] input = Console.ReadLine().Split(' ');
        int day = int.Parse(input[2]);
        int month = int.Parse(input[1]);
        int year = int.Parse(input[0]);

        DateTime start = DateTime.Today;
        DateTime end = new DateTime(year, month, day);

        int timeLen = 0;
        timeLen = Math.Abs((end - start).Days);
        if (start > end)
        {
            start = end;
            end = DateTime.Today;
        }

        DateTime[] holidays =
        {
            new DateTime(2013, 1, 1),
            new DateTime(2012, 3, 3),
            new DateTime(2012, 5, 1),
            new DateTime(2012, 5, 3),
            new DateTime(2012, 5, 4),
            new DateTime(2012, 5, 5),
            new DateTime(2012, 5, 6),
            new DateTime(2013, 12, 24),
            new DateTime(2013, 12, 25),
            new DateTime(2013, 12, 26)
        };

        bool isHoliday = false;
        int workDays = 0;
        for (int i = 0; i < timeLen; i++)
        {
            start = start.AddDays(1);
            if (start.DayOfWeek != DayOfWeek.Sunday && start.DayOfWeek != DayOfWeek.Saturday)
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (start == holidays[j])
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (!isHoliday)
                {
                    workDays++;
                }

                isHoliday = false;
            }
        }

        Console.WriteLine("There will be {0} working days.",workDays);
    }
}