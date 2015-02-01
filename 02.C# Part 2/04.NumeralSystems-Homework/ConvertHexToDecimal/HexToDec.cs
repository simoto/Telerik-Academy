using System;

//Write a program to convert hexadecimal numbers to their decimal representation.

class HexToDec
{
    static void Main()
    {
        Console.Write("Enter your hex number: ");
        string hex = Console.ReadLine();
        int result = Convert.ToInt32(hex, 16);
        Console.Write("Decimal representation is: ");
        Console.WriteLine(result);
    }
}