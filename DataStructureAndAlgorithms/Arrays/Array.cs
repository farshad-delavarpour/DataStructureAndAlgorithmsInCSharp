namespace DataStructureAndAlgorithms.Arrays
{
    public class Array
    {
        private int[] _items;
        private int _count;

        public Array(int length)
        {
            _items = new int[length];
        }

        public void Print()
        {
            for (var i = 0; i < _count; i++)
            {
                System.Console.WriteLine(_items[i]);
            }
        }

        public void Insert(int item)
        {
            if (_items.Length == _count)
            {
                var newArray = new int[_count * 2];

                for (var i = 0; i < _count; i++)
                {
                    newArray[i] = _items[i];
                }
                _items = newArray;
            }

            _items[_count] = (item);

            _count++;
        }

        public void RemoveAt(int index)
        {
            if (index >= _count)
                throw new IndexOutOfRangeException();

            for (int i = index; i < _count; i++)
            {
                _items[i] = _items[i + 1];
            }

            _items[_count - 1] = 0;
            _count--;
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_items[i] == item)
                    return i;
            }

            return -1;
        }
    }
}