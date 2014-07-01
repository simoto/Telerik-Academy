//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways: with and without using quoted strings.

using System;

class Quotations
{
    static void Main()
    {
        string strOne = @"The ""use"" of quotations causes difficulties.";
        string strTwo = "The \"use\" of quotations causes difficulties.";

        Console.WriteLine(strOne);
        Console.WriteLine(strTwo);
    }
}
