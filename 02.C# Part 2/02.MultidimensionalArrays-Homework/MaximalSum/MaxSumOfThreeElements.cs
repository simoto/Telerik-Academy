using System;

//Write a program that reads a rectangular matrix of size N x M 
//and finds in it the square 3 x 3 that has maximal sum of its elements.

class MaxSumOfThreeElements
{
    static void Main()
    {
        int[,] matrix = new int[,]
        {
            { 1, 2, 3, 4},
            { 5, 6, 2, 8},
            { 9, 4, 3, 6},
            { 5, 4, 1, 2},
            { 1, 3, 9, 8}
        };

        int maxSum = int.MinValue;
        int sum = 0;
        int startIndexRowMaxSum = 0;
        int startIndexColMaxSum = 0;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                sum += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    startIndexRowMaxSum = row;
                    startIndexColMaxSum = col;
                }

                sum = 0;
            }
        }

        Console.WriteLine(maxSum);
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write("{0,3} ", matrix[startIndexRowMaxSum, startIndexColMaxSum]);
                startIndexColMaxSum++;
            }

            startIndexColMaxSum -= 3;
            startIndexRowMaxSum++;
            Console.WriteLine();
        }
    }
}