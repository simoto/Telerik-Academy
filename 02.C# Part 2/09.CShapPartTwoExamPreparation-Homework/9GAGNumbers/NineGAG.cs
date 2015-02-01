using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

class NineGAG
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder list = new StringBuilder();
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            list.Append(input[i]);
            if (ConvertGagStringToNumber(list.ToString()) == "NO")
            {
                continue;
            }
            else
            {
                result.Append(ConvertGagStringToNumber(list.ToString()));
                list.Clear();
            }

        }

        string str = result.ToString();
        // Console.WriteLine(result.ToString());
        BigInteger finalResult = 0;
        int stepen = 0;
        for (int i = str.Length - 1; i >= 0; i--)
        {

            ulong digit = ulong.Parse(str[i].ToString());
            finalResult += Povdigane(stepen) * digit;
            stepen++;
        }

        Console.WriteLine(finalResult);
    }

    static string ConvertGagStringToNumber(string digit)
    {
        string result = "NO";
        switch (digit)
        {
            case "-!": result = "0"; break;
            case "**": result = "1"; break;
            case "!!!": result = "2"; break;
            case "&&": result = "3"; break;
            case "&-": result = "4"; break;
            case "!-": result = "5"; break;
            case "*!!!": result = "6"; break;
            case "&*!": result = "7"; break;
            case "!!**!-": result = "8"; break;
            default: break;
        }

        return result;
    }

    static BigInteger Povdigane(int stepen)
    {
        BigInteger result = 1;
        if (stepen == 0)
        {
            result = 1;
            return result;
        }
        else
        {
            for (int i = 1; i <= stepen; i++)
            {
                result = result * 9;
            }
            return result;
        }
    }
}