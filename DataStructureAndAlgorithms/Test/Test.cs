using System.Collections;
using System.Security.Cryptography;
using System.Text;

namespace DataStructureAndAlgorithms.Test;

public static class Test
{
    public static int Compress(char[] chars)
    {
        int i = 0, j = 0;
        while (i < chars.Length)
        {
            char current = chars[i];
            int counter = 0;
            while (i < chars.Length && chars[i] == current)
            {
                i++;
                counter++;
            }
            chars[j++] = current;
            if (counter > 1)
            {
                foreach (char number in counter.ToString().ToCharArray())
                    chars[j++] = number;
            }
        }
        return j;
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

    public static int gcd(int n1, int n2)
    {
        if (n2 == 0)
        {
            return n1;
        }
        else
        {
             return gcd(n2, n1 % n2);
        }
    }
    public static string GcdOfStrings(string str1, string str2)
    {
        int len1 = str1.Length;
        int len2 = str2.Length;
        if ((str1 + str2).Equals(str2 + str1))
        {
            int index = gcd(len1, len2);
            return str1.Substring(0, index);
        }
        else
        {
            return "";
        }
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