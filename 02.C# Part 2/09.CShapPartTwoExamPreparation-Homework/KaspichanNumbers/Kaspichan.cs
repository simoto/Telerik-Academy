using System;
using System.Collections.Generic;
using System.Text;

class Kaspichan
{
    static void Main()
    {
        ulong input = ulong.Parse(Console.ReadLine());

        List<string> list = new List<string>();

        for (int i = 'A'; i <= 'Z'; i++)
        {
            list.Add(((char)i).ToString());
        }

        for (int i = 'a'; i <= 'i'; i++)
        {
            for (int j = 'A'; j <= 'Z'; j++)
            {
                list.Add(((char)i).ToString() + ((char)j).ToString());
            }
        }

        if (input == 0)
        {
            Console.WriteLine("A");
        }

        Stack<string> result = new Stack<string>();

        while (input != 0)
        {
            result.Push(list[(int)(input % 256)].ToString());

            input /= 256;
        }

        for (int i = result.Count - 1; i >= 0; i--)
        {
            Console.Write(result.Pop());
        }
    }
}
