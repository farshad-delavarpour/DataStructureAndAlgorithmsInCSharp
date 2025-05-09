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
            if (IsEmpty())
                throw new InvalidOperationException("The stack is empty.");

            return _items[--_count];
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("The stack is empty.");

            return _items[_count - 1];
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }
    }

    public class DoubleStack
    {
        private int[] _items = new int[10];
        private int _count1;
        private int _count2;

        public void Push1(int item)
        {
        }
    }
}