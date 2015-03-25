namespace BiDictionary
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var dict = new BiDictionary<string, int, string>(allowDuplicateValues: true);
            dict.Add("net", 1, "ASP.NET");
            dict.Add("asp", 2, "ASP.NET");
            dict.Add("mean", 3, "JavaScript");
            dict.Add("mean", 3, "Mongo");
            dict.Add("laravel", 3, "PHP");
            dict.Add("laravel", 1, "Framework");

            Console.WriteLine(string.Join(" ", dict.GetByFirstKey("net")));
            Console.WriteLine(string.Join(" ", dict.GetBySecondKey(3)));
            Console.WriteLine(string.Join(" ", dict.GetByFirstAndSecondKey("mean", 3)));
            Console.WriteLine(dict.Count);

            dict.RemoveByFirstKey("laravel");
            Console.WriteLine(dict.Count);
            dict.RemoveBySecondKey(3);
            Console.WriteLine(dict.Count);
            dict.RemoveByFirstAndSecondKey("net", 1);
            Console.WriteLine(dict.Count);
        }
    }
}
