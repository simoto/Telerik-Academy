namespace Homework
{
    using System.Text;
    using System.Collections.Generic;

    //Implement an extension method Substring(int index, int length) 
    //for the class StringBuilder that returns new StringBuilder and 
    //has the same functionality as Substring in the class String.

    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder input, int startIndex, int length)
        {
            StringBuilder result = new StringBuilder();

            string common = input.ToString();
            common = common.Substring(startIndex, length);
            result.Append(common);
            return result;
        }

        //Implement a set of extension methods for IEnumerable<T> that implement 
        //    the following group functions: sum, product, min, max, average.

        public static int Sum<T>(this IEnumerable<T> input)
         {
             dynamic sum = 0;
             foreach (var item in input)
             {
                 sum += item;
             }

             return sum;
         }

        public static int Product<T>(this IEnumerable<T> input)
        {
            dynamic sum = 1;
            foreach (var item in input)
            {
                sum *= item;
            }

            return sum;
        }

        public static int Min<T>(this IEnumerable<T> input)
        {
            dynamic sum = int.MaxValue;
            foreach (var item in input)
            {
                if (sum > item)
                {
                    sum = item;
                }
            }

            return sum;
        }

        public static int Max<T>(this IEnumerable<T> input)
        {
            dynamic sum = int.MinValue;
            foreach (var item in input)
            {
                if (sum < item)
                {
                    sum = item;
                }
            }

            return sum;
        }

        public static int Average<T>(this IEnumerable<T> input)
        {
            dynamic sum = 0;
            int counter = 0;
            foreach (var item in input)
            {
                counter++;
                sum += item;
            }

            sum /= counter;

            return sum;
        }
    }
}