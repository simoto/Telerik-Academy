namespace CountSameItemOccurency
{
    using System;
    using System.Collections.Generic;

    /* Write a program that finds in given array of integers
        (all belonging to the range [0..1000]) how many
        times each of them occurs.
        Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
        2  2 times
        3  4 times
        4  3 times
     * */

    class CountSameItemOccurency
    {
        static void Main()
        {

            int[] array = new[] { 1, 2, 3, 5, 1, 2, 4, 3, 2, 1, 6, 7, };

            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            foreach (int number in array)
            {
                if (!dictionary.ContainsKey(number))
                {
                    dictionary[number] = 1;
                }
                else
                {
                    dictionary[number]++;
                }
            }

            foreach (var key in dictionary)
            {
                Console.WriteLine("Key {0} --> {1} times", key.Key, key.Value);
            }

        }
    }
}
