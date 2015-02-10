namespace SequenceQuery
{
    using System;
    using System.Collections.Generic;

   /* We are given the following sequence:
    S1= N;
    S2= S1+ 1;
    S3= 2*S1+ 1;
    S4= S1+ 2;
    S5= S2+ 1;
    S6= 2*S2+ 1;
    S7= S2+ 2;
...
Using the Queue<T> class write a program to print its first 50 members for given N
.
Example: N=2  2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
    */

    class SequenceQuery
    {
        static void Main()
        {
            int n = 2;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);

            for (int i = 0; i < 50; i++)
            {
                int current = queue.Dequeue();
                // index++;
                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current);
            }

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                Console.WriteLine(current);

            }
        }
    }
}