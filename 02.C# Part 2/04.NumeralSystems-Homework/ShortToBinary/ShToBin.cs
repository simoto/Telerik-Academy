using System;

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

class ShToBin
{
    static void Main()
    {
        Console.Write("Enter your short value: ");
        short number = short.Parse(Console.ReadLine());

        string result = Convert.ToString(number, 2);
        Console.Write("The binary representation is: ");
        Console.WriteLine(result);
    }
}