namespace SubsetOfStrings
{
    class Program
    {
        static void Main()
        {
            string[] input = new string[] { "test", "rock", "fun" };
            SubsetGenerator<string> allSubsets = new SubsetGenerator<string>(input);
            allSubsets.PrintSubsets(2);
        }
    }
}
