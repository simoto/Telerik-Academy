using System;

class Program
{
    static long count = 0;

    static void Main()
    {

        string input = Console.ReadLine();

        int countAsterisk = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '*')
            {
                countAsterisk++;
            }
        }

        long count = 1;

        for (int i = 1; i <= countAsterisk; i++)
        {
            count *= 2;
        }
        
        Console.WriteLine(count);
    }
}
