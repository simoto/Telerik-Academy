using System;
using System.Text;

//Write a program that reads a number and prints it as a decimal number,
//hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.

class PrintOnConsole
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Decimal value: {0,15:d}",number);
        Console.WriteLine("Hex value: {0,15:x}", number);
        Console.WriteLine("Percentace value: {0,15:p}", number);
        Console.WriteLine("Fixed value: {0,15:f}", number);
    }
}
