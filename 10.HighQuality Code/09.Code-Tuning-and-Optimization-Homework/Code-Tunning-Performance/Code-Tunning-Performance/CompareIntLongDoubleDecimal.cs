namespace CodeTunning
{
    using System;
    using System.Diagnostics;

    class CompareIntLongDoubleDecimal
    {
        static void DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        static void Main()
        {
            Console.Write("Int Add:\t\t");
            DisplayExecutionTime(() =>
            {
                int count = 1;
                for (int i = 0; i < 2000000; i++)
                {
                    count += 2;
                }
            });

            Console.Write("Int Subtract:\t\t");
            DisplayExecutionTime(() =>
            {
                int count = 2000000;
                for (int i = 0; i < 2000000; i++)
                {
                    count -= 2;
                }
            });

            Console.Write("Int Multiply:\t\t");
            DisplayExecutionTime(() =>
            {
                int count = 2;
                for (int i = 0; i < 2000000; i++)
                {
                    count *= 2;
                }
            });

            Console.Write("Int Divide:\t\t");
            DisplayExecutionTime(() =>
            {
                int count = 2000000;
                for (int i = 0; i < 2000000; i++)
                {
                    count /= 2;
                }
            });

            Console.WriteLine();
            Console.Write("Long Add:\t\t");
            DisplayExecutionTime(() =>
            {
                long count = 1;
                for (long i = 0; i < 2000000; i++)
                {
                    count += 2;
                }
            });

            Console.Write("Long Subtract:\t\t");
            DisplayExecutionTime(() =>
            {
                long count = 2000000;
                for (long i = 0; i < 2000000; i++)
                {
                    count -= 2;
                }
            });

            Console.Write("Long Multiply:\t\t");
            DisplayExecutionTime(() =>
            {
                long count = 2;
                for (long i = 0; i < 2000000; i++)
                {
                    count *= 2;
                }
            });

            Console.Write("Long Divide:\t\t");
            DisplayExecutionTime(() =>
            {
                long count = 2000000;
                for (long i = 0; i < 2000000; i++)
                {
                    count /= 2;
                }
            });

            Console.WriteLine();
            Console.Write("Float Add:\t\t");
            DisplayExecutionTime(() =>
            {
                float count = 1;
                for (int i = 0; i < 2000000; i++)
                {
                    count += 2;
                }
            });

            Console.Write("Float Subtract:\t\t");
            DisplayExecutionTime(() =>
            {
                float count = 2000000;
                for (int i = 0; i < 2000000; i++)
                {
                    count -= 2;
                }
            });

            Console.Write("Float Multiply:\t\t");
            DisplayExecutionTime(() =>
            {
                float count = 2;
                for (int i = 0; i < 2000000; i++)
                {
                    count *= 2;
                }
            });

            Console.Write("Float Divide:\t\t");
            DisplayExecutionTime(() =>
            {
                float count = 2000000;
                for (int i = 0; i < 2000000; i++)
                {
                    count /= 2;
                }
            });

            Console.WriteLine();
            Console.Write("Double Add:\t\t");
            DisplayExecutionTime(() =>
            {
                double count = 1;
                for (int i = 0; i < 2000000; i++)
                {
                    count += 2;
                }
            });

            Console.Write("Double Subtract:\t");
            DisplayExecutionTime(() =>
            {
                double count = 2000000;
                for (int i = 0; i < 2000000; i++)
                {
                    count -= 2;
                }
            });

            Console.Write("Double Multiply:\t");
            DisplayExecutionTime(() =>
            {
                double count = 2;
                for (int i = 0; i < 2000000; i++)
                {
                    count *= 2;
                }
            });

            Console.Write("Double Divide:\t\t");
            DisplayExecutionTime(() =>
            {
                double count = 2000000;
                for (int i = 0; i < 2000000; i++)
                {
                    count /= 2;
                }
            });

            Console.WriteLine();
            Console.Write("Decimal Add:\t\t");
            DisplayExecutionTime(() =>
            {
                decimal count = 1;
                for (int i = 0; i < 2000000; i++)
                {
                    count += 2;
                }
            });

            Console.Write("Decimal Subtract:\t");
            DisplayExecutionTime(() =>
            {
                decimal count = 2000000;
                for (int i = 0; i < 2000000; i++)
                {
                    count -= 2;
                }
            });

            Console.Write("Decimal Multiply:\t");
            DisplayExecutionTime(() =>
            {
                decimal count = 0.5m;
                for (int i = 0; i < 2000000; i++)
                {
                    count *= 0.5m;
                }
            });

            Console.Write("Decimal Divide:\t\t");
            DisplayExecutionTime(() =>
            {
                decimal count = 2000000;
                for (int i = 0; i < 2000000; i++)
                {
                    count /= 2;
                }
            });
        }
    }
}
