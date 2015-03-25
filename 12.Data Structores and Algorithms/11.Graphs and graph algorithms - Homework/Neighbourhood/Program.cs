﻿namespace Minimum_Spanning_Tree_Prim
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static Dictionary<Node, List<Connection>> neighbourhood;
        static Dictionary<int, Node> houses;

        public static void Main(string[] args)
        {
            neighbourhood = new Dictionary<Node, List<Connection>>();
            houses = new Dictionary<int, Node>();

            houses.Add(1, new Node(1));
            houses.Add(2, new Node(2));
            houses.Add(3, new Node(3));
            houses.Add(4, new Node(4));
            houses.Add(5, new Node(5));
            houses.Add(6, new Node(6));

            neighbourhood.Add(houses[1], new List<Connection>());
            neighbourhood.Add(houses[2], new List<Connection>());
            neighbourhood.Add(houses[3], new List<Connection>());
            neighbourhood.Add(houses[4], new List<Connection>());
            neighbourhood.Add(houses[5], new List<Connection>());
            neighbourhood.Add(houses[6], new List<Connection>());

            neighbourhood[houses[1]].Add(new Connection(houses[2], 2));
            neighbourhood[houses[1]].Add(new Connection(houses[4], 5));
            neighbourhood[houses[1]].Add(new Connection(houses[6], 6));

            neighbourhood[houses[2]].Add(new Connection(houses[1], 2));
            neighbourhood[houses[2]].Add(new Connection(houses[3], 8));
            neighbourhood[houses[2]].Add(new Connection(houses[4], 6));

            neighbourhood[houses[3]].Add(new Connection(houses[2], 8));
            neighbourhood[houses[3]].Add(new Connection(houses[4], 3));
            neighbourhood[houses[3]].Add(new Connection(houses[5], 5));

            neighbourhood[houses[4]].Add(new Connection(houses[1], 5));
            neighbourhood[houses[4]].Add(new Connection(houses[2], 6));
            neighbourhood[houses[4]].Add(new Connection(houses[3], 3));
            neighbourhood[houses[4]].Add(new Connection(houses[5], 6));
            neighbourhood[houses[4]].Add(new Connection(houses[6], 7));

            neighbourhood[houses[5]].Add(new Connection(houses[3], 5));
            neighbourhood[houses[5]].Add(new Connection(houses[4], 6));
            neighbourhood[houses[5]].Add(new Connection(houses[6], 2));

            neighbourhood[houses[6]].Add(new Connection(houses[1], 6));
            neighbourhood[houses[6]].Add(new Connection(houses[4], 7));
            neighbourhood[houses[6]].Add(new Connection(houses[5], 2));

            var startNode = houses[1];
            var minSpanningTree = PrimAlgorithm(startNode);

            Console.WriteLine("Minimum spanning tree connections:");
            foreach (var item in minSpanningTree)
            {
                if (item.Distance == 0)
                {
                    Console.WriteLine("The root is {0}", item.FromNode.Value);
                }
                else
                {
                    Console.WriteLine("Connection from {0} to {1} with distance {2}", item.FromNode.Value, item.ToNode.Value, item.Distance);
                }
            }
        }

        static ICollection<Connection> PrimAlgorithm(Node startNode)
        {
            var mst = new List<Connection>();
            PriorityQueue queue = new PriorityQueue();
            startNode.Used = true;
            Connection first = new Connection(startNode, 0);

            first.FromNode = startNode;

            mst.Add(first);

            foreach (var connection in neighbourhood[startNode])
            {
                queue.Enqueue(connection);
                connection.FromNode = startNode;
            }

            while (mst.Count != houses.Count)
            {
                var current = queue.Dequeue();

                current.ToNode.Used = true;
                mst.Add(current);

                foreach (var connection in neighbourhood[current.ToNode])
                {
                    if (!connection.ToNode.Used)
                    {
                        connection.FromNode = current.ToNode;
                        queue.Enqueue(connection);
                    }
                }
            }

            return mst;
        }
    }
}
