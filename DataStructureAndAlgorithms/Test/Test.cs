using System.Collections;
using System.Security.Cryptography;

namespace DataStructureAndAlgorithms.Test;

public static class Test
{
   
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


    public sealed class Circle
    {
        private static double radius;

        public static double Calculate(Func<double, int> op)
        {
            return op(radius);
        }

    }
}