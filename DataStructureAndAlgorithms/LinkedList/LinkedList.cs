namespace DataStructureAndAlgorithms.LinkedList
{
    public class LinkedList
    {
        private class Node
        {
            public Node(int value)
            {
                Value = value;
            }
            public Node(int value, Node next)
            {
                Value = value;
                Next = next;
            }
            public int Value { get; set; }
            public Node Next { get; set; }
        }

        private Node _first;
        private Node _last;

        public void AddFirst(int value)
        {
            Node node = new(value, _first);

            if (IsEmpty())
            {
                _first = _last = node;
            }
            else
            {
                _first = node;
            }
        }

        public void AddLast(int value)
        {
            Node newLastNode = new(value);

            if (IsEmpty())
            {
                _first = _last = newLastNode;
            }
            else
            {
                _last.Next = newLastNode;
                _last = newLastNode;
            }
        }

        public void Print()
        {
            var node = _first;
            while (node != null)
            {
                System.Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

        private bool IsEmpty() => _first == null;
    }
}