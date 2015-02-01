using System;

//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.

class SameNeighbor
{
    static void Main()
    {
        string[,] stringMatrix = 
        { 
            {"s", "qq", "s" },
            {"pp", "pp", "s" },
            {"pp", "qq", "s" }
        };

        int rows = stringMatrix.GetLength(0);
        int cols = stringMatrix.GetLength(1);

        int dcounter;
        int vcounter;
        int hcounter;
        int maxCounter = 0;
        string maxString = " ";

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                hcounter = 0;
                vcounter = 0;
                dcounter = 0;
                while (col < cols - 1)
                {
                    if (stringMatrix[row, col] == stringMatrix[row, col + 1])
                    {
                        hcounter++;
                        col++;
                        maxString = stringMatrix[row, col];
                    }
                    else
                    {
                        break;
                    }
                }
                while (row < rows - 1)
                {
                    if (stringMatrix[row, col] == stringMatrix[row + 1, col])
                    {
                        vcounter++;
                        row++;
                        maxString = stringMatrix[row, col];
                    }
                    else
                    {
                        break;
                    }
                }
                while (row < rows - 1 || col < cols - 1)
                {
                    if (stringMatrix[row, col] == stringMatrix[row + 1, col + 1])
                    {
                        dcounter++;
                        row++;
                        col++;
                        maxString = stringMatrix[row, col];
                    }
                    else
                    {
                        break;
                    }
                }

                if (maxCounter < vcounter)
                {
                    maxCounter = vcounter;
                }

                if (maxCounter < dcounter)
                {
                    maxCounter = dcounter;
                }

                if (maxCounter < hcounter)
                {
                    maxCounter = hcounter;
                }
            }
        }

        for (int i = 0; i < maxCounter + 1; i++)
        {
            Console.Write(maxString + " ");
        }

        Console.WriteLine();
    }
}