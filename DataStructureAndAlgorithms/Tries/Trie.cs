using System.Text;

namespace DataStructureAndAlgorithms.Tries
{
    public class Trie
    {
        private TrieNode Root { get; set; } = new TrieNode(' ');

        public void Insert(string value)
        {
            TrieNode current = Root;

            foreach (char @char in value)
            {
                if (!current.HasChild(@char))
                    current.AddChild(@char);
                current = current.GetChild(@char);
            }
            current.IsEndOfWord = true;
        }

        public bool Contains(string value)
        {
            if(value is null)
                return false;

            TrieNode current = Root;
            foreach (char @char in value)
            {
                if(!current.HasChild(@char))
                    return false;
                current = current.GetChild(@char);
            }
            return current.IsEndOfWord;
        }

        public List<string> GetWords(string value)
        {
            List<string> words = new();
            TrieNode prefixNode = FindPrefixNode(value);

            if (prefixNode != null)
                GetWordsFromNode(prefixNode, value, words);

            return words;
        }

        private TrieNode FindPrefixNode(string prefix)
        {
            TrieNode current = Root;
            foreach (char @char in prefix)
            {
                if (!current.HasChild(@char))
                    return null;
                current = current.GetChild(@char);
            }
            return current;
        }

        private void GetWordsFromNode(TrieNode node, string prefix, List<string> words)
        {
            if (node is null)
                return;

            if (node.IsEndOfWord)
                words.Add(prefix);

            foreach (TrieNode child in node.GetChildren())
            {
                GetWordsFromNode(child, prefix + child.Value, words);
            }
        }

        private class TrieNode
        {
            public TrieNode(char @char)
            {
                Value = @char;
            }

            public char Value { get; set; }
            public Dictionary<char, TrieNode> Children { get; set; } = new();
            public bool IsEndOfWord { get; set; }

            public bool HasChild(char @char) => Children.ContainsKey(@char);

            public void AddChild(char @char) => Children.Add(@char, new TrieNode(@char));

            public TrieNode GetChild(char @char) => Children[@char];

            public IEnumerable<TrieNode> GetChildren() => Children.Values;
        }
    }
}
