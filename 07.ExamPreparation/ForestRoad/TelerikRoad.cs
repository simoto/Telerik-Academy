using System;

class TelerikRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = 2 * n - 1;
        byte asterisk = 1;
        int dot = n - 1;

        for (int aa = 0; aa < n; aa++)
        {
            Console.Write(new string('.', aa));
            Console.Write(new string('*', asterisk));
            Console.Write(new string('.', dot));
            dot--;
            Console.WriteLine();
        }

        dot = n - 2;
        for (int i = 1; i < n; i++)
        {
            Console.Write(new string('.', dot));
            Console.Write(new string('*', asterisk));
            Console.Write(new string('.', i));
            Console.WriteLine();
            dot--;
        }
    }
}
