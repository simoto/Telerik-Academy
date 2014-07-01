//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.
using System;

class Exchange
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("A = {0} , B = {1}", a, b);
        b = b - a;
        a = a + b;
        Console.WriteLine("A = {0} , B = {1}", a, b);
    }
}
