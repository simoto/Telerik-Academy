using System;
using System.Collections.Generic;
using System.Text;

class MagicWord
{
    static void Main()
    {
        List<string> list = new List<string>();

        int words = int.Parse(Console.ReadLine());

        for (int i = 0; i < words; i++)
        {
            list.Add(Console.ReadLine().ToString());
        }

        for (int i = 0; i < words; i++)
        {
            string word = list[i];
            int newIndex = word.Length % (words + 1);

            list.Insert(newIndex, word);

            if (newIndex < i)
            {
                list.RemoveAt(i + 1);
            }
            else
            {
                list.RemoveAt(i);
            }
        }

        int maxLenth = 0;
        foreach (string item in list)
        {
            if (maxLenth < item.Length)
            {
                maxLenth = item.Length;
            }
        }

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < maxLenth; i++)
        {
            foreach (string item in list)
            {
                if (item.Length > i)
                {
                    result.Append(item[i]);
                }
            }
        }

        Console.WriteLine(result.ToString());
    }
}
