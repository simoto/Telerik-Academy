namespace FirstExercise
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static Node<int> FindRoot(Node<int>[] nodes)
        {
            var hasParent = new bool[nodes.Length];

            foreach (var node in nodes)
            {
                foreach (var item in node.Children)
                {
                    hasParent[item.Value] = true;
                }
            }

            for (int i = 0; i < hasParent.Length; i++)
            {
                if (!hasParent[i])
                {
                    return nodes[i];
                }
            }

            throw new ArgumentException();
        }

        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            var nodes = new Node<int>[N];

            for (int i = 0; i < N; i++)
            {
                nodes[i] = new Node<int>(i);
            }

            for (int i = 1; i <= N - 1; i++)
            {
                string edgeAsString = Console.ReadLine();
                var edgeParts = edgeAsString.Split(' ');

                int parentID = int.Parse(edgeParts[0]);
                int childID = int.Parse(edgeParts[1]);

                nodes[parentID].Children.Add(nodes[childID]);
                nodes[childID].HasParent = true;
            }

            //1. Find the root
            Node<int> root = FindRoot(nodes);
            Console.WriteLine("The root of the tree is: {0}", root.Value);

            //2. Find all leafs
            var leafs = FindAllLeafs(nodes);
            Console.Write("Leafs: ");
            foreach (var leaf in leafs)
            {
                Console.Write("{0}, ", leaf.Value);
            }

            Console.WriteLine();

            //3. Find all middle nodes
            var middleNodes = FindAllMiddleNodes(nodes);
            Console.Write("Middle: ");
            foreach (var node in middleNodes)
            {
                Console.Write("{0}, ", node.Value);
            }

            Console.WriteLine();

            //4. Find the longest path
            var longestPath = FindLongestPath(FindRoot(nodes));
            Console.WriteLine("Longest path is: {0}", longestPath);
        }

        private static List<Node<int>> FindAllMiddleNodes(Node<int>[] nodes)
        {
            List<Node<int>> middleNodes = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.HasParent && node.Children.Count > 0)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }

        private static int FindLongestPath(Node<int> root)
        {
            if (root.Children.Count == 0)
            {
                return 0;
            }

            int maxPath = 0;
            foreach (var node in root.Children)
            {
                maxPath = Math.Max(maxPath, FindLongestPath(node));
            }

            return maxPath + 1;
        }

        private static List<Node<int>> FindAllLeafs(Node<int>[] nodes)
        {
            List<Node<int>> leafs = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    leafs.Add(node);
                }
            }

            return leafs;
        }


    }
}
