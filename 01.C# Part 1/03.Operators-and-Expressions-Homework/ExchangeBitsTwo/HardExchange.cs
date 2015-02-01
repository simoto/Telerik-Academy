//* Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.
using System;

class HardExchange
{
    static void Main()
    {
        Console.Write("Enter number : ");
        uint number = uint.Parse(Console.ReadLine());
        Console.Write("Enter p : ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter q : ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter k : ");
        int k = int.Parse(Console.ReadLine());

        int positionOne = BitPosition(number, p);
        int positionTwo = BitPosition(number, (p + 1));
        int positionThree = BitPosition(number, (p + k - 1));
        int onePosition = BitPosition(number, q);
        int twoPosition = BitPosition(number, q + 1);
        int threePosition = BitPosition(number, q + k - 1);

        number = ModNum(number, p, onePosition);
        number = ModNum(number, (p + 1), twoPosition);
        number = ModNum(number, (p + k - 1), threePosition);
        number = ModNum(number, q, positionOne);
        number = ModNum(number, (q + 1), positionTwo);
        number = ModNum(number, (q + k - 1), positionThree);

        Console.Write("Your number after bit exchange is: ");
        Console.WriteLine(number);
    }
    private static int BitPosition(uint number, int position)
    {
        uint BitPosition = (number >> position) & 1;
        return (int)BitPosition;
    }
    private static uint ModNum(uint number, int position, int bitValue)
    {
        uint actualPosition = (uint)bitValue << position;
        number = number & (~((uint)1 << position));
        uint result = number | actualPosition;
        return result;
    }
}