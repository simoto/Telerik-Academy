using System;

class BatGoiko
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int row = n - 1;
        int cow = n;
        int dash = 0;
        int dot = 0;

        for (int i = 0; i < cow; i++)
        {
            Console.Write(new string('.', row));
            Console.Write(new string('/', 1));

            if (i == 1 || i == 3 || i == 6 || i == 10 || i == 15 || i == 21 || i == 28 || i == 36)
            {
                Console.Write(new string('-', dash));
            }
            else
            {
                Console.Write(new string('.', dot));
            }

            Console.Write(new string('\\', 1));
            Console.WriteLine(new string('.', row));
            dot += 2;
            dash += 2;
            row--;
        }
    }
}
