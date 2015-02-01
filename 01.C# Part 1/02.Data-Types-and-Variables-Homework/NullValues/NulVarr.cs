//Create a program that assigns null values to an integer and to double variables.
//Try to print them on the console, try to add some values or the null literal to them and see the result.
using System;

class NulVarr
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("Int null value: " + a);
        Console.WriteLine("Double null value: " + b);

        a = 54;
        b = 4.5;

        Console.WriteLine("Int with some value: " + a);
        Console.WriteLine("Double with some value: " + b);
    }
}
