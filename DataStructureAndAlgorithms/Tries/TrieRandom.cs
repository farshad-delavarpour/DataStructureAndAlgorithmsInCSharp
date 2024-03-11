using System.Text;

namespace DataStructureAndAlgorithms.Tries
{
    public class TrieRandom
    {
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            Trie trie = new();
            foreach (string product in products)
                trie.Insert(product);

            StringBuilder enteredChars = new();
            List<List<string>> result = new();
            foreach(char @char in searchWord)
            {
                enteredChars.Append(@char);
                List<string> suggestedProducts = trie.GetWords(enteredChars.ToString());
                result.Add(suggestedProducts);
            }
            return result.ToArray();
        }
    }
}
