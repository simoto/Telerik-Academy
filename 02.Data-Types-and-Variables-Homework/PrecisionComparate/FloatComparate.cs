//Write a program that safely compares floating-point numbers with precision of 0.000001.
//Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

using System;

class FloatComparate
{
    static void Main()
    {
        Console.Write("Insert first value here: ");
        float first = float.Parse(Console.ReadLine());
        Console.Write("Insert second value here: ");
        float second = float.Parse(Console.ReadLine());

        bool comparate = (first == second);
        if (comparate == true)
        {
            Console.WriteLine("Result is: " + comparate);
        }
        else
        {
            Console.WriteLine("Result is: " + comparate);
        }
    }
}
