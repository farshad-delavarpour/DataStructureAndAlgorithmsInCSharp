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
        private int _size;

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
            _size++;
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
            _size++;
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
                _first = _last = null;
            else
            {
                var second = _first.Next;
                _first.Next = null;
                _first = second;
            }
            _size--;
        }

        public void RemoveLast()
        {
            if (IsEmpty())
                throw new InvalidOperationException("The LinkedList is empty.");

            if (IsSingle())
                _first = _last = null;
            else
            {
                var lastParent = GetPrevious(_last);
                lastParent.Next = null;
                _last = lastParent;
            }
            _size--;
        }

        public int Size() => _size;

        public int[] ToArray()
        {
            var array = new int[_size];
            var index = 0;
            var current = _first;

            while (current != null)
            {
                array[index++] = current.Value;
                current = current.Next;
            }

            return array;
        }
        public void Reverse()
        {
            if (IsEmpty())
                throw new InvalidOperationException("The LinkedList is empty.");

            var previous = _first;
            var current = _first.Next;

            while (current != null)
            {
                var next = current.Next;

                current.Next = previous;

                previous = current;
                current = next;
            }

            var first = _first;
            _first = _last;
            _last = first;
            _last.Next = null;
        }

        public int GetKthNodeFromTheEnd(int k)
        {
            if (k < 1 || k > _size)
                throw new IndexOutOfRangeException();

            if (IsEmpty())
                throw new InvalidOperationException("The LinkedList is empty.");

            var current = _first;
            var target = _first;

            for (int i = 0; i < k - 1; i++)
                target = target.Next;

            while (target != _last)
            {
                current = current.Next;
                target = target.Next;
            }

            return current.Value;
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