﻿//Declare a character variable and assign it with the symbol that has Unicode code 72. 
//Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

using System;

class CharVariable
{
    static void Main()
    {
        char @char = (char)0x48;
        Console.WriteLine(@char);
    }
}