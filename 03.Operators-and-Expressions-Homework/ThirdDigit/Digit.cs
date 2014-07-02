//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.
using System;

class Digit
{
    static void Main()
    {
        Console.Write("Insert number: ");

        int a = int.Parse(Console.ReadLine());
        int b = a / 100;
        int c = b % 10;
        bool result = (c == 7);

        if (result == true)
        {
            Console.WriteLine("The third digit is 7.");
        }
        else
        {
            Console.WriteLine("The third digit isn't 7.");
        }
    }
}
