using System;

//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
// a, b, c, d

class Matrix
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());
        int digit = 1;

        int[,] matrix = new int[n, n];
        
        //// Variant A
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = digit;
                digit++;
            }
        }

        //print matrix A
        Console.WriteLine("Variant A:");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,4}", matrix[row, col]);  
            }

            Console.WriteLine();
        }

        digit = 1;
        Console.WriteLine();

        // Variant B
        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = digit;
                    digit++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[row, col] = digit;       
                    digit++;
                }
            }
        }

        //print matrix B
        Console.WriteLine("Variant B:");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }

            Console.WriteLine();
        }

        digit = 1;
        Console.WriteLine();

        // Variant C
        int r = n - 1;
        int c = 0;
        int StartRow = n - 1;
        int StartCol = 0;
        matrix[r, c] = 1;

        while (digit < n * n)
        {
            if (r == (n - 1) && c < (n - 1))
            {
                StartRow--;
                StartCol = 0;
                r = StartRow;   
                c = StartCol;
                digit++;
                matrix[r, c] = digit;

                while (r < (n - 1) && c < (n - 1))
                {
                    r++;
                    c++;
                    digit++;
                    matrix[r, c] = digit;
                }
            }
            
            if (r <= (n - 1) && c == (n - 1))
            {
                StartRow = 0;
                StartCol++;
                r = StartRow;
                c = StartCol;   
                digit++;        
                matrix[r, c] = digit;

                while (c < (n - 1))
                {
                    r++;    //Move down
                    c++;    //Move right
                    digit++;
                    matrix[r, c] = digit;
                }
            }
        }

        //print variant C
        Console.WriteLine("Variant C:");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }

            Console.WriteLine();
        }

        digit = 1;
        Console.WriteLine();

        //Variant D
        int offset = 0;
        int Row = 0;
        int Col = 0;

        while (digit <= n * n)
        {
            
            for (Row = offset; Row < n - offset; Row++)
            {
                Col = offset;
                matrix[Row, Col] = digit;
                digit++;
            }
            
            for (Col = 1 + offset; Col < n - offset; Col++)
            {
                Row = n - 1 - offset;
                matrix[Row, Col] = digit;
                digit++;
            }
            
            for (Row = n - 2 - offset; Row >= offset; Row--)
            {
                Col = n - 1 - offset;
                matrix[Row, Col] = digit;
                digit++;
            }
            
            for (Col = n - 2 - offset; Col >= offset + 1; Col--)
            {
                Row = offset;
                matrix[Row, Col] = digit;
                digit++;
            }

            offset++;
        }

        // print variant D
        Console.WriteLine("Variant D:");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }

            Console.WriteLine();
        }

        digit = 1;
        Console.WriteLine();          
    }
}