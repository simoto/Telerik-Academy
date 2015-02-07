using System;

//Write a program that compares two char arrays lexicographically (letter by letter).

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Enter all elements for the first array without white space between(example: abcd ): ");
        string firstInput = Console.ReadLine();
        char[] firstArray = firstInput.ToCharArray();

        Console.Write("Enter all elements for the first array without white space between(example: abcd ): ");
        string secondInput = Console.ReadLine();
        char[] secondArray = secondInput.ToCharArray();

        int minLength = Math.Min(firstArray.Length, secondArray.Length);
        int currentElementFromFirstArray;
        int currentElementFromSecondArray;

        for (int i = 0; i < minLength; i++)
        {
            currentElementFromFirstArray = firstArray[i];
            currentElementFromSecondArray = secondArray[i];
            if (currentElementFromFirstArray == currentElementFromSecondArray)
            {
                Console.WriteLine("Elements at position {0} are equals.", i);
            }
            else if (currentElementFromFirstArray > currentElementFromSecondArray)
            {
                Console.WriteLine("The element from the first array is after the second. At position {0}", i);
            }
            else
            {
                Console.WriteLine("The element from the second array is after the first. At position {0}", i);
            }
        }
    }
}