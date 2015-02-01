//Declare five variables choosing for each of them the most appropriate of the types
//byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:
//52130, -115, 4825932, 97, -10000.

using System;

class DeclareVariables
{
    static void Main()
    {
        sbyte one = -115;
        byte two = 97;
        short three = -10000;
        ushort four = 52130;
        int five = 4825932;

        Console.WriteLine("{0} is a sbyte \n {1} is a byte \n{2} is a short \n{3} is an ushort \n {4} is an int",
            one, two, three, four, five);
    }
}

