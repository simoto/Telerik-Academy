using System;

//Write a program that reads two integer arrays from the console and compares them element by element.

class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter all elements for the first array separated by white space(example: 1 4 5 23 ): ");
        string firstInput = Console.ReadLine();
        string[] firstArray = firstInput.Split(new[] { ' ' });

        Console.Write("Enter all elements for the second array separated by white space(example: 1 4 5 23 ): ");
        string secondInput = Console.ReadLine();
        string[] secondArray = secondInput.Split(new[] { ' ' });

        int minLength = Math.Min(firstArray.Length, secondArray.Length);
        int currentElementFromFirstArray;
        int currentElementFromSecondArray;

        for (int i = 0; i < minLength; i++)
        {
            currentElementFromFirstArray = int.Parse(firstArray[i]);
            currentElementFromSecondArray = int.Parse(secondArray[i]);
            if (currentElementFromFirstArray == currentElementFromSecondArray)
            {
                Console.WriteLine("Elements at position {0} are equals.", i);
            }
            else if (currentElementFromFirstArray > currentElementFromSecondArray)
            {
                Console.WriteLine("The element from the first array is bigger. At position {0}", i);
            }
            else
            {
                Console.WriteLine("The element from the second array is bigger. At position {0}", i);
            }
        }
    }
}