﻿using System;

//Write a program that prints to the console which day of the week is today. Use System.DateTime.

class DOfWeek
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine("Today is {0}", now.DayOfWeek);
    }
}