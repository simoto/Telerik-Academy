using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MathOperationCompare
{
    class MathOperationCompare
    {
        const int IterationCount = (int)1.6E7;

        static readonly Stopwatch stopwatch = new Stopwatch();

        static void DisplayExecutionTime(string title, Action action)
        {
            Console.Write("{0, -20}", title);
            stopwatch.Restart();

            action();

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        static void Main()
        {

            {
                DisplayExecutionTime("Square root float", () =>
                {
                    for (float i = 1; i < IterationCount; i++)
                        Math.Sqrt(i);
                });

                DisplayExecutionTime("Square root double", () =>
                {
                    for (double i = 1; i < IterationCount; i++)
                        Math.Sqrt(i);
                });

            }

            Console.WriteLine();

            {
                DisplayExecutionTime("Log float", () =>
                {
                    for (float i = 1; i < IterationCount; i++)
                        Math.Log(i);
                });

                DisplayExecutionTime("Log double", () =>
                {
                    for (double i = 1; i < IterationCount; i++)
                        Math.Log(i);
                });
            }

            Console.WriteLine();

            {
                DisplayExecutionTime("Sin float", () =>
                {
                    for (float i = 1; i < IterationCount; i++)
                        Math.Sin(i);
                });

                DisplayExecutionTime("Sin double", () =>
                {
                    for (double i = 1; i < IterationCount; i++)
                        Math.Sin(i);
                });
            }

        }
    }
}
