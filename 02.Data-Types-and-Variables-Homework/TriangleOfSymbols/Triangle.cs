//Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
//Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.
using System;

class Triangle
{
    static void Main()
    {
        char copyright = '\u00A9';
        Console.WriteLine("    " + copyright + "    ");
        Console.WriteLine("   " + copyright + copyright + copyright + "   ");
        Console.WriteLine("  " + copyright + copyright + copyright + copyright + copyright + "  ");
    }
}
