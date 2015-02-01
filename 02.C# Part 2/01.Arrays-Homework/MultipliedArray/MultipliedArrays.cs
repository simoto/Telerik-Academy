﻿using System;

/*Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
 * Print the obtained array on the console. 
 */

class MultipliedArrays
{
    static void Main()
    {
        int[] myArray = new int[20];

        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = i;
        }

        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] *= 5;
        }

        //printing obtained array
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write("Element {0} is: ",i + 1);
            Console.WriteLine(myArray[i]);
        }
    }
}