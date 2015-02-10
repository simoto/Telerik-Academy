namespace ReverseWithStack
{
    using System;
    using System.Collections.Generic;

    //Write a program that reads N integers from the console and reverses them using a stack. Use the Stack<int> class.

    class ReverseWithStack
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();

            string input = Console.ReadLine();
            int inputAsNumber;

            while (input != String.Empty)
            {
                inputAsNumber = int.Parse(input);
                stack.Push(inputAsNumber);
                input = Console.ReadLine();
            }

            foreach (var number in stack)
            {
                Console.WriteLine(number);
            }

        }
    }
}
