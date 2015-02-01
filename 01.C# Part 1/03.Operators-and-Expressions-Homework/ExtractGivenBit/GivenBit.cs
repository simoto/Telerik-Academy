﻿//We are given integer number n, value v (v=0 or 1) and a position p.
//Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
//    Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//    n = 5 (00000101), p=2, v=0  1 (00000001)
using System;

class GivenBit
{
    static void Main()
    {
        Console.Write("Insert number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Insert position: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write(@"Insert value (you can use only ""0"" or ""1""): ");
        int v = int.Parse(Console.ReadLine());

        if (v == 1)
        {
            int mask = 1 << p;
            int maskAndNumber = n | mask;
            Console.WriteLine(maskAndNumber);
        }
        else if (v == 0)
        {
            int mask = ~(1 << p);
            int maskAndNumber = n & mask;
            Console.WriteLine(maskAndNumber);
        }
        else
        {
            Console.WriteLine("You have entered wrong values!");
        }

    }
}