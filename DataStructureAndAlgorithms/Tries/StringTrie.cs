using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DataStructureAndAlgorithms.Tries
{
    internal class StringTrie
    {
        public StringTrie(string value)
        {
            Root = new StringTrieNode(value);
        }
        private StringTrieNode Root { get; set; }

        public void Insert(string parent, string value)
        {
            InsertRecursive(Root, parent, value);
        }

        private void InsertRecursive(StringTrieNode node, string parent, string value)
        {
            if (node == null)
                return;

            if (node.Value == parent)
            {
                node.AddChild(value);
                return;
            }

            foreach (var child in node.GetChildren())
            {
                InsertRecursive(child, parent, value);
            }
        }

        public void PrintInOrder()
        {
            Queue<StringTrieNode> queue = new Queue<StringTrieNode>();
            queue.Enqueue(Root);
            queue.Enqueue(null); // Add a marker to indicate the end of the level

            while (queue.Count > 0)
            {
                StringTrieNode node = queue.Dequeue();

                if (node != null)
                {
                    Console.Write(node + " ");
                    foreach (StringTrieNode child in node.GetChildren())
                    {
                        queue.Enqueue(child);
                    }
                }
                else // If the marker is encountered, it means the level has ended
                {
                    Console.WriteLine(); // Move to the next level
                    if (queue.Count > 0)
                        queue.Enqueue(null); // Add a marker for the next level
                }
            }
        }

        //public void PrintInOrder()
        //{
        //    Queue<NodeOrder> queue = new();
        //    queue.Enqueue(new NodeOrder(Root, 0));
        //    int level = 0;
        //    while (queue.Count > 0) 
        //    {
        //        NodeOrder node = queue.Dequeue();
        //        Console.Write(node.Node + " ");
        //        if(node.Level > level)
        //            Console.Write(Environment.NewLine);
        //        foreach (StringTrieNode child in node.Node.GetChildren())
        //        {
        //            queue.Enqueue(new NodeOrder(child, node.Level + 1));
        //        }
        //    }
        //}

        //private struct NodeOrder
        //{
        //    public NodeOrder(StringTrieNode node, int level)
        //    {
        //        Node = node;
        //        Level = level;
        //    }

        //    public StringTrieNode Node { get; set; }
        //    public int Level { get; set; }
        //}

        private void PrintInOrderRecursive(StringTrieNode node)
        {
            if (node == null)
                return;

            Console.Write(node + " ");

            foreach (var child in node.GetChildren())
            {
                PrintInOrderRecursive(child);
            }
        }

        private class StringTrieNode
        {
            public StringTrieNode(string value)
            {
                Value = value;
                Children = new();
            }

            public string Value { get; set; }
            private List<StringTrieNode> Children { get; set; }
            
            public bool HasChild(string value) => Children.Any(c => c.Value == value);
            
            public void AddChild(string value) => Children.Add(new StringTrieNode(value));

            public IEnumerable<StringTrieNode> GetChildren() => Children;

            public override string ToString()
            {
                return Value;
            }
        }
    }
}
