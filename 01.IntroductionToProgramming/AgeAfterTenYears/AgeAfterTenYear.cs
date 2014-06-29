//Write a program to read your birthday from the console and print how old you are
//now and how old you will be after 10 years.
using System;

class AgeAfterTenYear
{
    static void Main()
    {
        int age = 0;
        bool valid = false;
        while (!valid)
        {
            Console.Write("Enter your age: ");
            valid = int.TryParse(Console.ReadLine(), out age);
        }

        Console.WriteLine("After ten years you will be: " + (age + 10));
    }
}