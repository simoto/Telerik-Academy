//Write a program that, depending on the user's choice inputs int, double or string variable. 
//If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
//The program must show the value of that variable as a console output. Use switch statement.

using System;

class IntDoubleOrString
{
    static void Main()
    {
        byte userChoice;
        Console.WriteLine("Please enter 1 for integer, 2 for double and 3 for string:");
        userChoice = byte.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                Console.WriteLine("enter an integer:");
                int intResult = int.Parse(Console.ReadLine());
                intResult++;
                Console.WriteLine("modified integer = {0}", intResult);
                break;
            case 2:
                Console.WriteLine("enter a double value:");
                double doubleResult = double.Parse(Console.ReadLine());
                doubleResult++;
                Console.WriteLine("modified double = {0}", doubleResult);
                break;
            case 3:
                Console.WriteLine("enter a string:");
                string stringResult = Console.ReadLine();
                stringResult += "*";
                Console.WriteLine("modified string = {0}", stringResult);
                break;
            default:
                Console.WriteLine("Something broke");
                break;
        }
    }
}

