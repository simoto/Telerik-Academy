using System;

//Write a program to convert hexadecimal numbers to binary numbers (directly).

class HexToBin
{
    static void Main()
    {
        Console.Write("Enter your hex number: ");
        string hex = Console.ReadLine();
        int converts = Convert.ToInt32(hex, 16);
        string result = Convert.ToString(converts, 2);
        Console.Write("Binary representation is: ");
        Console.WriteLine(result);
    }
}