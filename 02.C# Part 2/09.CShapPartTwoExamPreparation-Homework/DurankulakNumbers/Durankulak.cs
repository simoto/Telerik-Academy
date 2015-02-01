using System;
using System.Collections.Generic;
using System.Text;

class Durankulak
{
    static void Main()
    {
        List<string> list = new List<string>();

        for (int i = 'A'; i <= 'Z'; i++)
        {
            list.Add(((char)i).ToString());
        }

        for (int i = 'a'; i < 'f'; i++)
        {
            for (int j = 'A'; j <= 'Z'; j++)
            {
                list.Add(((char)i).ToString() + ((char)j).ToString());
            }
        }

        for (int i = 'f'; i <= 'f'; i++)
        {
            for (int j = 'A'; j <= 'L'; j++)
            {
                list.Add(((char)i).ToString() + ((char)j).ToString());
            }
        }

        string input = Console.ReadLine();

        StringBuilder innerIndex = new StringBuilder();
        Stack<int> outerIndex = new Stack<int>();

        for (int i = 0; i < input.Length; i++)
        {
            innerIndex.Append(input[i]);
            for (int j = 0; j < 168; j++)
            {
                if (innerIndex.ToString() == list[j])
                {
                    outerIndex.Push(j);
                    innerIndex.Clear();
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        ulong finalResult = 0;
        ulong start = 1;
        int count = outerIndex.Count;
        for (int i = 0; i < count; i++)
        {
            finalResult += (ulong)outerIndex.Pop() * (start);
            start *= 168;
        }

        Console.WriteLine(finalResult);
    }
}
