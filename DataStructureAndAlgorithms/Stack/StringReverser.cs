using System.Text;

namespace DataStructureAndAlgorithms.Stack
{
    public static class StringReverser
    {
        public static string Reverse(string value)
        {
            Stack<char> stack = new();

            foreach (var c in value)
            {
                stack.Push(c);
            }
            StringBuilder result = new();

            while (stack.Count != 0)
                result.Append(stack.Pop());

            return result.ToString();
        }
    }
}