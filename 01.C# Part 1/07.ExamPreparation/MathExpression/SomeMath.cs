using System;

class SomeMath
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        double nStepen = n * n;
        double partTwo = 1 / (m * p);
        double partThree = 1337;
        double partFour = nStepen + partTwo + partThree;
        double partFive = n - 128.523123123 * p;
        double partSix = partFour / partFive;
        int partSeven = (int)m % 180;
        double partEight = Math.Sin(partSeven);
        Console.WriteLine("{0:f6}", partSix + partEight);
    }
}
