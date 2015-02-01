//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
using System;

class ThirdBit
{
    static void Main()
    {
        int position = 3;

        Console.Write("Insert number: ");
        int b = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int bAndMask = b & mask;
        int bit = bAndMask >> position;

        if (bit == 1)
        {
            Console.WriteLine("The third bit is 1");
        }
        else
        {
            Console.WriteLine("The third bit is 0");
        }
    }
}
