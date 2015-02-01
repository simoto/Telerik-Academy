//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class CalculateSumWithAccuracy
{
    static void Main()
    {
        double divisor = 2, result = 1, tempSum = 1;

        while (tempSum > 0.001f)
        {
            tempSum = 1f / divisor;

            if (divisor % 2 == 0)
            {
                result += tempSum;
            }
            else
            {
                result -= tempSum;
            }

            divisor++;
        }

        Console.WriteLine(result);
    }
}

