using System;
using System.Collections.Generic;

public class CountArray
{
    static void Main()
    {
        double[] array = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

        Dictionary<double, int> countArrayValues = new Dictionary<double, int>();

        foreach (var number in array)
        {
            if (!countArrayValues.ContainsKey(number))
            {
                countArrayValues[number] = 1;
            }
            else
            {
                countArrayValues[number]++;
            }
        }


        foreach (var item in countArrayValues)
        {
            Console.WriteLine("Number: {0} --> {1} times", item.Key, item.Value);
        }

    }
}
