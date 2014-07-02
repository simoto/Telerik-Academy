//Write an expression that extracts from a given integer i the value of a given bit number b. 
//Example: i=5; b=2  value=1.
using System;

class BitValue
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

        if (bit == 1)
        {
            Console.WriteLine("The bit on position {0} is 1.", p);
        }
        else
        {
            Console.WriteLine("The bit on position {0} is not 1.", p);
        }
    }
}