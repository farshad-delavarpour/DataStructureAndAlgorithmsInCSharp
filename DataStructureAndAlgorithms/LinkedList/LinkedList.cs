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

        public void AddFirst(int item)
        {
            Node node = new(item, _first);

            if (IsEmpty())
            {
                _first = _last = node;
            }
            else
            {
                _first = node;
            }
        }

        public void AddLast(int item)
        {
            Node newLastNode = new(item);

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

        public int IndexOf(int item)
        {
            var index = 0;

            var current = _first;

            while (current != null)
            {
                if (current.Value == item) return index;

                current = current.Next;
                index++;
            }

            return -1;
        }

        public bool Contains(int item) => IndexOf(item) != -1;

        public void RemoveFirst()
        {
            if (IsEmpty())
                throw new InvalidOperationException("The LinkedList is empty.");

            if (IsSingle())
            {
                _first = _last = null;
                return;
            }

            var second = _first.Next;
            _first.Next = null;
            _first = second;
        }

        public void RemoveLast()
        {
            if (IsEmpty())
                throw new InvalidOperationException("The LinkedList is empty.");

            if (IsSingle())
            {
                _first = _last = null;
                return;
            }

            var lastParent = GetPrevious(_last);
            lastParent.Next = null;
            _last = lastParent;
        }

        private Node GetPrevious(Node node)
        {
            var current = _first;
            while (current != null)
            {
                if (current.Next == node) return current;
                current = current.Next;
            }
            return null;
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
        private bool IsSingle() => _first == _last;
    }
}