using System;

//Write a program to convert binary numbers to hexadecimal numbers (directly).

class BinToHex
{
    static void Main()
    {
        Console.Write("Enter your binary number: ");
        string hex = Console.ReadLine();
        int converts = Convert.ToInt32(hex, 2);
        string result = Convert.ToString(converts, 16).ToUpperInvariant();
        Console.Write("Hex representation is: ");
        Console.WriteLine(result);
    }
}
