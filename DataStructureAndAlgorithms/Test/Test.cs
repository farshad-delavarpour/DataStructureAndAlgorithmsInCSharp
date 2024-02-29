using System.Collections;
using System.Security.Cryptography;

namespace DataStructureAndAlgorithms.Test;

public static class Test
{
    public static char GetFirstNonRepeat(string str)
    {
        Dictionary<char, int> test = new();
        foreach (char @char in str)
        {
            if (test.ContainsKey(@char))
                test[@char] += 1;
            else
                test.Add(@char, 1);
        }

        return test.FirstOrDefault(i => i.Value == 1).Key;
    }

    public static int[] ReturnUnique(int[] list)
    {
        HashSet<int> sets = new();
        foreach (int item in list)
            sets.Add(item);
        return sets.ToArray();
    }


}

public class Node
{
    public Node(int val)
    {
        this.val = val;
    }
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}
public class Test2
{
    private LinkedList<Node> list = new();

    public Node Flatten(Node head)
    {
        Process(head);
        return list.First.Value;
    }

    private void Process(Node node)
    {
        while (node != null)
        {
            list.AddLast(new Node(node.val));
            ProcessChild(node);
            node = node.next;
        }
    }

    private void ProcessChild(Node node)
    {
        if (node.child == null)
            return;
        Node child = node.child;
        Process(child);
    }


    public void Point()
    {
        var numbers = new int[] { 3, 4, 5 };
        IEnumerable<IGrouping<string, int>> grouped = numbers.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");
        var test = grouped.First(f => f.)


    }

    public sealed class Circle
    {
        private static double radius;

        public static double Calculate(Func<double, int> op)
        {
            return op(radius);
        }

    }
}