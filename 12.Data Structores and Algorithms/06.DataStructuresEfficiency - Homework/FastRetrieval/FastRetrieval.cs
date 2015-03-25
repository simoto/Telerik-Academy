namespace FastRetrieval
{
    using System;
    using Wintellect.PowerCollections;

    public class FastRetrieval
    {
        static void Main()
        {
            OrderedMultiDictionary<decimal, Article> dict = new OrderedMultiDictionary<decimal, Article>(true);

            AddArticlesToDictionary(dict);

            //test search
            var searchResult = dict.Range(10, true, 100, true);
        }

        private static void AddArticlesToDictionary(OrderedMultiDictionary<decimal, Article> dict)
        {
            for (int i = 0; i < 10; i++)
            {
                dict.Add(i * 10, new Article()
                    {
                        Barcode = i.ToString(),
                        Price = i * 10,
                        Title = i.ToString(),
                        Vendor = i.ToString()
                    });
            };
        }
    }
}
