using System;
using System.Text;

class MultiComm
{
    static void Main()
    {
        string[] alphabet = { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };

        string input = Console.ReadLine();

        StringBuilder alphabetIndex = new StringBuilder();
        long decValue = 0;
        long representation = 0;
        for (int i = 0; i < input.Length; i += 3)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (alphabet[j] == input.Substring(i, 3))
                {
                    alphabetIndex.Append(j);
                    decValue = j;
                    representation *= 13;
                    representation += decValue;
                    break;
                }
            }
        }

        Console.WriteLine(representation);
    }
}
