//Write a boolean expression that returns if the bit at position p (counting from 0)
//in a given integer number v has value of 1. Example: v=5; p=1  false.
using System;

class BitBool
{
    static void Main()
    {
        Console.Write("Insert your number: ");
        int v = int.Parse(Console.ReadLine());

        Console.Write("Insert bit position: ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int vAndMaske = v & mask;
        int bit = vAndMaske >> p;
        bool result = (bit == 1);

        if (result == true)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(result);
        }
    }
}
