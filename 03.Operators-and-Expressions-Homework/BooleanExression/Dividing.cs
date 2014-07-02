//Write a boolean expression that checks for given integer if it can be divided (without remainder)
//by 7 and 5 in the same time.
using System;

class Dividing
{
    static void Main()
    {
        Console.Write("Is your number devided by 5 and 7 at the same time? \n Insert your number: ");

        int a = int.Parse(Console.ReadLine());

        Console.WriteLine(a % 5 == 0 && a % 7 == 0);
    }
}
