//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
using System;

class Exchange
{
    static void Main()
    {
        Console.Write("Enter your number here: ");
        uint num = uint.Parse(Console.ReadLine());

        int posThree = BitPosition(num, 3);
        int posFour = BitPosition(num, 4);
        int posFive = BitPosition(num, 5);
        int posTwentyFour = BitPosition(num, 24);
        int posTwentyFive = BitPosition(num, 25);
        int posTwentySix = BitPosition(num, 26);

        num = ModNum(num, 3, posTwentyFour);
        num = ModNum(num, 4, posTwentyFive);
        num = ModNum(num, 5, posTwentySix);
        num = ModNum(num, 24, posThree);
        num = ModNum(num, 25, posFour);
        num = ModNum(num, 26, posFive);

        Console.Write("Your number after bit exchange is: ");
        Console.WriteLine(num);
    }
    private static int BitPosition(uint number, int position)
    {
        uint BitPosition = (number >> position) & 1;
        return (int)BitPosition;
    }

    private static uint ModNum(uint number, int position, int bitValue)
    {
        uint actualP = (uint)bitValue << position;
        number = number & (~((uint)1 << position));
        uint result = number | actualP;
        return result;
    }
}