namespace DataStructureAndAlgorithms.Tries
{
    public class Trie
    {
        private TrieNode Root { get; set; }

        public void Insert(string value)
        {
            TrieNode current = Root;
            foreach(char @char in value)
            {
                if(!current.HasChild(@char))
                    current.AddChild(@char);
                current = current.GetChild(@char);
            }
            current.IsEndOfWord = true;
        }

        private class TrieNode
        {
            public TrieNode(char value)
            {
                Value = value;
            }

            public char Value { get; set; }
            public Dictionary<char, TrieNode> Children { get; set; }
            public bool IsEndOfWord { get; set; }

            public override string ToString()
            {
                return Value.ToString();
            }

            public bool IsEmpty() => !Children.Any();

            public bool HasChild(char value) => Children.ContainsKey(value);

            public TrieNode GetChild(char value) => Children[value];

            public void AddChild(char value) => Children.Add(value, new TrieNode(value));
        }
    }
}
