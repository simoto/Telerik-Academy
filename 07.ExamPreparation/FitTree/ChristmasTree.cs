using System;

class ChristmasTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int asterisk = 1;
        int dots = n - 2;
        int endPoint = dots;

        string firstLine = (new string('.', dots) + "*" + (new string('.', dots)));
        Console.WriteLine(firstLine);
        dots--;

        for (int i = 0; i < endPoint; i++)
        {
            Console.Write(new string('.', dots));
            Console.Write(new string('*', (asterisk += 2)));
            Console.WriteLine(new string('.', dots));
            dots--;
        }

        Console.WriteLine(firstLine);
    }
}
