using System;

//Write a program that compares two char arrays lexicographically (letter by letter).

class ComparChar
{
    static void Main()
    {
        //reading of first array
        Console.Write("Enter value for first array elements: ");
        string strFirstArray = Console.ReadLine();
        char[] firstArray = strFirstArray.ToCharArray();

        //reading of second array
        Console.Write("Enter value for second array elements: ");
        string strSecondAray = Console.ReadLine();
        char[] secondArray = strSecondAray.ToCharArray();

        //comparate
        string strFromFirstArray = new string(firstArray);
        string strFromSecondArray = new string(secondArray);

        int comparate = strFromFirstArray.CompareTo(strFromSecondArray);
        if (comparate == 0)
        {
            Console.WriteLine("Arrays are equal");
        }
        else if (comparate == -1)
        {
            Console.WriteLine("The first array is first.");
        }
        else
        {
            Console.WriteLine("The second array is first.");
        }
    }
}