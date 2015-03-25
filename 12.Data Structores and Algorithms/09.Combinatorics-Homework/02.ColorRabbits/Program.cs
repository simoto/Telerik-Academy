using System;
using System.Collections.Generic;

class Program
{
    // this solution is 64/100 points
    static void Main()
    {
        byte rabbitCount = byte.Parse(Console.ReadLine());

        Dictionary<int, int> rabbitOrder = new Dictionary<int, int>();

        for (int i = 0; i < rabbitCount; i++)
        {
            int current = int.Parse(Console.ReadLine()) + 1;

            if (rabbitOrder.ContainsKey(current))
            {
                rabbitOrder[current]++;
            }
            else
	        {
                rabbitOrder[current] = 1;
	        }
        }

        long result = 0;

        foreach (var item in rabbitOrder)
        {
            result += item.Key;
        }

        Console.WriteLine(result);
    }
}
