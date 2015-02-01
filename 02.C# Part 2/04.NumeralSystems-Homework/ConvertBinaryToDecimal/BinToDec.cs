using System;

//Write a program to convert binary numbers to their decimal representation.

class BinToDec
{
    static void Main()
    {
        Console.Write("Enter your binary number: ");
        string binary = Console.ReadLine();
        ConvertToDecimal(binary);
    }

    static void ConvertToDecimal(string bin)
    {
        char[] array = bin.ToCharArray();
        int sum = 0;
        int stepen = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            sum += int.Parse(array[i].ToString()) << stepen;
            stepen++;
        }

        Console.Write("The decimal value is: ");
        Console.WriteLine(sum);
    }
}