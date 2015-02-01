using System;

class UK
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int inDots = n / 2 - 1;
        int outDots = 0;

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', outDots));
            Console.Write('\\');
            Console.Write(new string('.', inDots));
            Console.Write('|');
            Console.Write(new string('.', inDots));
            Console.Write('/');
            Console.Write(new string('.', outDots));

            Console.WriteLine();
            outDots++;
            inDots--;
        }

        Console.Write(new string('-', n / 2));
        Console.Write('*');
        Console.WriteLine(new string('-', n / 2));

        outDots = n / 2 - 1;
        inDots = 0;

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', outDots));
            Console.Write('/');
            Console.Write(new string('.', inDots));
            Console.Write('|');
            Console.Write(new string('.', inDots));
            Console.Write('\\');
            Console.Write(new string('.', outDots));

            Console.WriteLine();
            outDots--;
            inDots++;
        }
    }
}