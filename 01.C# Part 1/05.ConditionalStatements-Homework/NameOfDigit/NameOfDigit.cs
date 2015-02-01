//Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.

using System;

class NameOfDigit
{
    static void Main()
    {
        Console.Write("Enter one digit between 0 and 9: ");
        int input = int.Parse(Console.ReadLine());

        string output = "";

        switch (input)
        {
            case 0: output = "zero"; break;
            case 1: output = "one"; break;
            case 2: output = "two"; break;
            case 3: output = "three"; break;
            case 4: output = "four"; break;
            case 5: output = "five"; break;
            case 6: output = "six"; break;
            case 7: output = "seven"; break;
            case 8: output = "eight"; break;
            case 9: output = "nine"; break;
            default:
                break;
        }

        Console.WriteLine("The name of the number is: {0}", output);
    }
}
