namespace DataStructureAndAlgorithms.Stack
{
    public class Stack
    {
        private int[] _items = new int[5];
        private int _count;

        public void Push(int item)
        {
            if (_count == _items.Length)
                throw new StackOverflowException();

            _items[_count++] = item;
        }

        public int Pop()
        {
            if (_count == 0)
                throw new InvalidOperationException("The stack is empty.");

            return _items[--_count];
        }

        public int Peek()
        {
            if (_count == 0)
                throw new InvalidOperationException("The stack is empty.");

            return _items[_count - 1];
        }
    }
}