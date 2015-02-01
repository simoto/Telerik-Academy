using System;
using System.Collections.Generic;
using System.Text;


class Decode
{
    static void Main()
    {
        string inputFormat = Console.ReadLine();
        string[] format = inputFormat.Split(' ');

        int letterPerLineCount = int.Parse(format[0]);
        int letterPerSubSequence = int.Parse(format[1]);

        string encodedGenome = Console.ReadLine();

        StringBuilder decodedGenome = DecodeGenom(encodedGenome);

        PrintFormattedGenome(decodedGenome, letterPerLineCount, letterPerSubSequence);
    }

    private static void PrintFormattedGenome(StringBuilder decodedGenome, int letterPerLineCount, int letterPerSubSequence)
    {
        int outputLines = (int)Math.Ceiling(decodedGenome.Length / (double)letterPerLineCount);
        int oneLine = (int)Math.Ceiling((double)letterPerLineCount / letterPerSubSequence);
        int maxLineNumberDigits = outputLines.ToString().Length;
        StringBuilder currentFormattedLine = new StringBuilder();
        int currentIndexInDecodedGenome = 0;
        string decript = decodedGenome.ToString();

        for (int i = 1; i <= outputLines; i++)
        {
            currentFormattedLine.Append(new string(' ', outputLines.ToString().Length - i.ToString().Length));
            currentFormattedLine.Append(i.ToString());
            currentFormattedLine.Append(' ');
            int symbolCount = 1;

            for (int a = 0; a < oneLine; a++)
            {
                if (symbolCount - 1 == letterPerLineCount)
                {
                    break;
                }
                for (int j = 0; j < letterPerSubSequence; j++)
                {
                    if (symbolCount - 1 == letterPerLineCount)
                    {
                        break;
                    }
                    if (currentIndexInDecodedGenome >= decript.Length)
                    {
                        break;
                    }
                    currentFormattedLine.Append(decript[currentIndexInDecodedGenome]);
                    currentIndexInDecodedGenome++;
                    symbolCount++;
                }
                if (symbolCount - 1 < letterPerLineCount)
                {
                    if (currentIndexInDecodedGenome >= decript.Length)
                    {
                        break;
                    }
                    currentFormattedLine.Append(' ');
                }

            }
            if (i == outputLines)
            {
                Console.Write(currentFormattedLine.ToString().TrimEnd());
                currentFormattedLine.Clear();
            }
            else
            {
                Console.Write(currentFormattedLine.ToString().TrimEnd() + "\n");
                currentFormattedLine.Clear();
            }
        }

    }

    static StringBuilder DecodeGenom(string encodedGenome)
    {
        StringBuilder decodedGenome = new StringBuilder();

        StringBuilder repeatTimesString = new StringBuilder();

        foreach (char symbol in encodedGenome)
        {
            if (symbol == 'A' || symbol == 'C' || symbol == 'G' || symbol == 'T')
            {
                int repeatTimes = 1;

                if (repeatTimesString.Length != 0)
                {
                    repeatTimes = int.Parse(repeatTimesString.ToString());
                    repeatTimesString.Clear();
                }

                string genomeSubsequence = new string(symbol, repeatTimes);
                decodedGenome.Append(genomeSubsequence);
            }
            else
            {
                repeatTimesString.Append(symbol);
            }
        }

        return decodedGenome;
    }
}
