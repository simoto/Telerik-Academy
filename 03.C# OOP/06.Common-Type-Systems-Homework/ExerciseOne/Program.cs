namespace Exercises
{
    using System;

    class Program
    {
        static void Main()
        {
            Person kiko = new Person("Kiril", 30);
            Console.WriteLine(kiko);
            Console.WriteLine();
            Person pesho = new Person("Pesho", null);
            Console.WriteLine(pesho);
            Console.WriteLine();


            BitArray64 arr = new BitArray64(3);
            arr.Add(1234567);
            arr.Add(3456743);
            arr.Add(9789236);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            BitArray64 arr2 = new BitArray64(3);
            arr2.Add(3434567);
            arr2.Add(3446436743);
            arr2.Add(9783436);
            Console.WriteLine();

            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine(arr.Equals(arr2));
            Console.WriteLine(arr.GetHashCode());

            arr2[0] = 1;
            Console.WriteLine("Check for equality: {0}", arr == arr2);
        }
    }
}