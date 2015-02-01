using System;

//Write a program to convert decimal numbers to their binary representation.

class DecToBin
{
    static void Main()
    {
        Console.Write("Enter your number here: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("The binary value is: ");
        ConvertToBinary(number);

    }

    static void ConvertToBinary(int num)
    {
        string result ="";
        while (num > 0)
        {
            result += (num % 2).ToString();
            num /= 2;
        }

        for (int i = result.Length-1; i >= 0; i--)
        {
            Console.Write("{0}",result[i]);
        }

        Console.WriteLine();
    }
}