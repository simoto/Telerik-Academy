//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
//34.567839023, 12.345, 8923.1234857, 3456.091?

using System;

class FloatingPoint
{
    static void Main()
    {
        float one = 12.345f;
        float two = 3456.091f;
        double dOne = 34.567839023;
        double dTwo = 8923.1234857;

        Console.WriteLine("{0} and {1} are float \n{2} and {3} are double", one, two, dOne, dTwo);
    }
}
