using System;

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

class CorectExpression
{
    static void Main()
    {
        Console.Write("Enter your expression: ");
        string expresion = Console.ReadLine();

        Console.WriteLine(IsCorrectExpression(expresion));
        
    }

    static bool IsCorrectExpression(string str)
    {
        int stack = 0;

        for (int i = 0; i < str.Length && stack >= 0; i++)
        {
            if (str[i] == '(')
            {
                stack++;
            }
            if (str[i] == ')')
            {
                stack--;
            }
        }

        return stack == 0;
    }
}