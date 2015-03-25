using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    class Program
    {
        static void Main()
        {

            Item[] items = new Item[] 
            {
                new Item("beer", 3, 2),
                new Item("vodka", 8, 12),
                new Item("cheese", 4, 5),
                new Item("nuts", 1, 4),
                new Item("ham", 2, 3),
                new Item("whiskey", 8, 13),
            };

            int capacity = 10;

            Console.WriteLine("Best choie: ");
            Console.WriteLine(String.Join(" ", Knapsack(items, capacity).Select(r => r.Name)));
        }

        private static List<Item> Knapsack(Item[] items, int capacity)
        {
            if (capacity == 0)
            {
                return new List<Item>();
            }

            if (items.Length == 0)
            {
                return new List<Item>();
            }

            int[,] costArray = new int[items.Length, capacity + 1];
            int[,] bagArray = new int[items.Length, capacity + 1];

            for (int i = 0; i < items.Length; i++)
            {
                costArray[i, 0] = 0;
                bagArray[i, 0] = 0;
            }

            for (int i = 1; i <= capacity; i++)
            {
                if (items[0].Weight <= i)
                {
                    costArray[0, i] = items[0].Value;
                    bagArray[0, i] = 1;
                }
                else
                {
                    costArray[0, i] = 0;
                    bagArray[0, i] = 0;
                }
            }

            for (int x = 0; x < items.Length - 1; x++)
            {
                for (int y = 1; y <= capacity; y++)
                {
                    var currentItem = items[x + 1];

                    if (currentItem.Weight > y)
                    {
                        costArray[x + 1, y] = costArray[x, y];
                        continue;
                    }

                    int valueWhenDropping = costArray[x, y];
                    int valueWhenTaking = costArray[x, y - currentItem.Weight] + currentItem.Value;

                    if (valueWhenTaking > valueWhenDropping)
                    {
                        costArray[x + 1, y] = valueWhenTaking;
                        bagArray[x + 1, y] = 1;
                    }
                    else
                    {
                        costArray[x + 1, y] = valueWhenDropping;
                        bagArray[x + 1, y] = 0;
                    }
                }
            }

            var bestItems = new List<Item>();

            int remainingSpace = capacity;
            int item = items.Length - 1;

            while (item >= 0 && remainingSpace >= 0)
            {
                if (bagArray[item, remainingSpace] == 1)
                {
                    bestItems.Add(items[item]);
                    remainingSpace -= items[item].Weight;
                    item -= 1;
                }
                else
                {
                    item -= 1;
                }
            }

            return bestItems;
        }
    }
}
