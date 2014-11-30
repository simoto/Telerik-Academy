using System;
//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:

class Matrix
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());
        int num = 1;
        if (n < 20)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    Console.Write((num++) + " ");
                }
                num = row + 1;
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}

