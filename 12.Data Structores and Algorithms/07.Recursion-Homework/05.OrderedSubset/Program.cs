/* Write a recursive program for generating and printing all ordered k-element subsets
 * from n-element set (variations Vkn).
	Example: n=3, k=2, set = {hi, a, b} =>
	(hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)
*/

namespace OrderedSubset
{
    class Program
    {
        static void Main()
        {
            string[] elements = new string[] { "hi", "a", "b" };
            SubsetGenerator<string> generator = new SubsetGenerator<string>(elements);
            generator.PrintSubsets(2);
        }
    }
}
