using System.Collections.Generic;
namespace Trie
{
    public class Node
    {
        public string Word;
        public bool IsTerminal { get { return Word != null; } }
        public Dictionary<string, Node> Edges = new Dictionary<string, Node>();
    }
}
