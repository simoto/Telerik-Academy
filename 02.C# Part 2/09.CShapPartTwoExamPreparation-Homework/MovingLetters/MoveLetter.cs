using System;
using System.Text;

class MoveLetter
{
    static void Main()
    {

        string input = Console.ReadLine();

        string[] separatedWords = input.Split(' ');
        int longestWord = 0;

        foreach (string word in separatedWords)
        {
            if (longestWord < word.Length)
            {
                longestWord = word.Length;
            }
        }

        StringBuilder blodja = new StringBuilder();

        for (int i = 1; i <= longestWord; i++)
        {
            foreach (var item in separatedWords)
            {
                if (item.Length - i >= 0)
                {
                    blodja.Append(item[item.Length - i]);
                }

            }
        }

        string preparedBloja = blodja.ToString();


        int a = preparedBloja.Length;
        for (int i = 0; i < a; i++)
        {
            char currentChar = blodja[i];
            blodja[i] = '1';
            int newIndex = ReturnPosition(currentChar) + i;
            while (newIndex > a - 1)
            {
                newIndex -= a;
            }

            if (newIndex < i)
            {
                blodja.Remove(i, 1);
                blodja.Insert(newIndex, currentChar);
            }
            else
            {
                //newIndex += 1;
                blodja.Remove(i, 1);
                blodja.Insert(newIndex, currentChar);
            }

        }

        Console.WriteLine(blodja.ToString());

    }

    static int ReturnPosition(char symbol)
    {
        //int result = 0;
        string abs = "1abcdefghijklmnopqrstuvwxyz";
        int index = abs.IndexOf(symbol.ToString().ToLower());

        return index;
    }
}
