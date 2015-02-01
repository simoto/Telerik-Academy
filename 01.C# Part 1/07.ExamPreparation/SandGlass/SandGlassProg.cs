using System;

class SandGlassProg
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int n2 = n;
        int endDot = n / 2;

        for (int i = n, j = 0; j <= endDot; n -= 2, j++)
        {
            Console.Write(new string('.', j));
            Console.Write(new string('*', n));
            Console.WriteLine(new string('.', j));
        }

        n = 1;
        n += 2;
        endDot--;
        for (int i = n, j = endDot; j >= 0; n += 2, j--)
        {
            Console.Write(new string('.', j));
            Console.Write(new string('*', n));
            Console.WriteLine(new string('.', j));
        }
    }
}
