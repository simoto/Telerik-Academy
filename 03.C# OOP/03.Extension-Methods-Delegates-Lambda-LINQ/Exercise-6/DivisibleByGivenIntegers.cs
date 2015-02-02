using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace Homework
{
    class DivisibleByGivenIntegers
    {
        static void Main()
        {
            int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 21, 42, 123, 234, 345, 45, 23, 12, 56 };

            var allDivisible = from integer in integers
                               where integer % 3 == 0 && integer % 7 == 0
                               select integer;

            foreach (var item in allDivisible)
            {
                Console.WriteLine(item);
            }
        }
    }
}