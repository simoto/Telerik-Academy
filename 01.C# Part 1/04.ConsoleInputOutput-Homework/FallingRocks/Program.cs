/* Implement the "Falling Rocks" game in the text console. 
    A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
    A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
*/
using System;
using System.Threading;

class FallingRocks
{
    static int score = 0;
    static int dwarfPosition = 23 - 1;
    static Random randomGenerator = new Random();
    static char[,] rocksPositions = new char[Console.WindowWidth, Console.WindowHeight];
    static int rowsOfRocks = 1;
    static char[] arrayOfChars = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
    static void printSymbol(int x, int y, char ch)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(ch);
    }

    static void printDwarf(int dwarfPosition)
    {
        printSymbol(dwarfPosition - 1, Console.WindowHeight - 1, '(');
        printSymbol(dwarfPosition, Console.WindowHeight - 1, '0');
        printSymbol(dwarfPosition + 1, Console.WindowHeight - 1, ')');
    }

    static void moveRocks()
    {
        if (rowsOfRocks < Console.WindowHeight - 2)
        {
            for (int y = rowsOfRocks; y >= 0; y--)
            {
                {
                    for (int i = 0; i < Console.WindowWidth; i++)
                    {
                        rocksPositions[i, y + 1] = rocksPositions[i, y];
                    }

                }
            }

        }
        else
        {
            for (int i = Console.WindowHeight - 1; i > 0; i--)
            {
                for (int y = 0; y < Console.WindowWidth; y++)
                {
                    rocksPositions[y, i] = rocksPositions[y, i - 1];
                }
            }
            if (rowsOfRocks == Console.BufferHeight - 1)
            {
                score += 100;
            }//on every row of rocks avoided adds 100 points  
        }
        generateRocksOnRow(0);
    }

    static void generateRocksOnRow(int row)
    {
        for (int i = 0; i < Console.WindowWidth; i++)
        {
            int randomNumber = randomGenerator.Next(1, 101);
            int randomChar = randomGenerator.Next(0, 10);
            if (randomNumber < 7)
            {
                rocksPositions[i, row] = arrayOfChars[randomChar];
            }
            else
            {
                rocksPositions[i, row] = ' ';
            }
        }
    }

    static void printRocks()
    {
        for (int i = 0; i < Console.WindowHeight; i++)
        {
            for (int y = 0; y < Console.WindowWidth; y++)
            {

                if (rocksPositions[y, i] != ' ')
                {
                    printSymbol(y, i, rocksPositions[y, i]);
                }

            }
        }

    }

    static void printScore()
    {
        Console.SetCursorPosition(18, 1);
        Console.Write(score);
    }
    static void Main()
    {
        Console.SetWindowSize(45, 20);
        Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
        generateRocksOnRow(0);
        while (true)
        {
            Thread.Sleep(150);
            Console.Clear();
            printScore();
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if ((keyInfo.Key == ConsoleKey.RightArrow) && (dwarfPosition < Console.WindowWidth - 3))
                {
                    dwarfPosition++;
                }

                if ((keyInfo.Key == ConsoleKey.LeftArrow) && (dwarfPosition > 1))
                {
                    dwarfPosition--;
                }
            }

            printDwarf(dwarfPosition);
            if (rowsOfRocks == (Console.WindowHeight - 1) && rocksPositions[dwarfPosition, Console.BufferHeight - 1] != ' ')
            {
                score -= 1000;
            }

            if (rowsOfRocks < Console.WindowHeight - 1)
            {
                rowsOfRocks++;
            }
            moveRocks();
            printRocks();
        }
    }
}
