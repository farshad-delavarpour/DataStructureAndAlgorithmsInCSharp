namespace DataStructureAndAlgorithms.Stack
{
    public static class Expression
    {
        public static bool IsBalanced(string input)
        {
            Dictionary<char, char> charachters = new(){
                {'<', '>'},
                {'(', ')'},
                {'[', ']'},
                {'{', '}'},
            };

            Stack<char> charachtersStack = new();

            foreach (var ch in input)
            {
                if (charachters.ContainsKey(ch))
                    charachtersStack.Push(ch);

                if (charachters.ContainsValue(ch))
                {
                    var key = charachters.First(c => c.Value == ch).Key;
                    if (charachtersStack.Pop() != key)
                        return false;
                }
            }

            return charachtersStack.Count == 0;
        }
    }
}