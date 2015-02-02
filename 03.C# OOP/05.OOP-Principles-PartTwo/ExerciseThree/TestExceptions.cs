//Write a sample application that demonstrates the InvalidRangeException<int> and 
//InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

namespace ExerciseThree
{
    using System;

    class TestExceptions
    {
        static void Main()
        {
            int start = 0;
            int end = 100;
                        
            Console.Write("Enter a number in range {0} - {1} : ", start, end);
            int number = int.Parse(Console.ReadLine());

            if (number < start || number > end)
            {
                throw new InvalidRangeException<int>(start, end);
            }
            else
            {
                Console.WriteLine("Your number is {0}", number);
            }

            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);

            Console.Write("Enter a date in range {0:MM/dd/yyyy} - {1:MM/dd/yyyy} : ", startDate, endDate);
            DateTime inputData = DateTime.Parse(Console.ReadLine());

            if (inputData < startDate || inputData > endDate)
            {
                throw new InvalidRangeException<DateTime>(startDate, endDate);
            }
        }
    }
}