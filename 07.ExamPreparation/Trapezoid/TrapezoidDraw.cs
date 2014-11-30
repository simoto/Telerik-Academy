using System;

class TrapezoidDraw
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int top = n;
        int bottom = n * 2;
        int height = n + 1;
        int otherDots = n - 1;
        Console.Write(new string('.', n));
        Console.WriteLine(new string('*', n));
        n--;
        for (int i = 1; i < bottom; i++)
        {
            Console.Write(new string('.', n));
            Console.Write("*");
            Console.Write(new string('.', otherDots));
            Console.WriteLine("*");
            n--;
            otherDots++;
            if (n == 0)
            {
                break;
            }
        }

        Console.WriteLine(new string('*', (bottom)));
    }
}